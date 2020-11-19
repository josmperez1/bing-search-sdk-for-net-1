﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Xml;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VideoSearchQuickstart
{
    class Program
    {
        // In production, make sure you're pulling the subscription key from secured storage.

        private static string _subscriptionKey = "<YOUR SUBSCRIPTION KEY GOES HERE>";
        private static string _baseUri = "https://api.bing.microsoft.com/v7.0/videos/search";

        // Each of the query parameters you may specify.

        private const string QUERY_PARAMETER = "?q=";  // Required
        private const string MKT_PARAMETER = "&mkt=";  // Strongly suggested
        private const string COUNT_PARAMETER = "&count=";
        private const string OFFSET_PARAMETER = "&offset=";
        private const string ID_PARAMETER = "&id=";
        private const string SAFE_SEARCH_PARAMETER = "&safeSearch=";

        // Each of the filter query parameters you may specify.

        private const string ASPECT_PARAMETER = "&aspect=";
        private const string EMBEDDED_PARAMETER = "&embedded=";
        private const string FRESHNESS_PARAMETER = "&freshness=";
        private const string PRICING_PARAMETER = "&pricing=";
        private const string RESOLUTION_PARAMETER = "&resolution=";
        private const string VIDEO_LENGTH_PARAMETER = "&videoLength=";

        // The user's search string.

        private static string _searchString = "hummingbird";

        // To page through images, you'll need the next offset that Bing returns.

        private static long _nextOffset = 0;

        // Bing uses the X-MSEdge-ClientID header to provide users with consistent
        // behavior across Bing API calls. See the reference documentation
        // for usage.

        private static string _clientIdHeader = null;


        static void Main()
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            try
            {
                // Remember to encode the q query parameter.

                var queryString = QUERY_PARAMETER + Uri.EscapeDataString(_searchString);
                queryString += MKT_PARAMETER + "en-us";

                HttpResponseMessage response = await MakeRequestAsync(queryString);

                _clientIdHeader = response.Headers.GetValues("X-MSEdge-ClientID").FirstOrDefault();

                // This example uses dictionaries instead of objects to access the response data.

                var contentString = await response.Content.ReadAsStringAsync();
                Dictionary<string, object> searchResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(contentString);

                if (response.IsSuccessStatusCode)
                {
                    PrintVideos(searchResponse);
                }
                else
                {
                    PrintErrors(response.Headers, searchResponse);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nPress ENTER to exit...");
            Console.ReadLine();
        }

        // Makes the request to the Video Search endpoint.

        static async Task<HttpResponseMessage> MakeRequestAsync(string queryString)
        {
            var client = new HttpClient();

            // Request headers. The subscription key is the only required header but you should
            // include User-Agent (especially for mobile), X-MSEdge-ClientID, X-Search-Location
            // and X-MSEdge-ClientIP (especially for local aware queries).

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);

            return (await client.GetAsync(_baseUri + queryString));
        }

        // Prints the list of videos in the JSON response.

        static void PrintVideos(Dictionary<string, object> response)
        {
            Newtonsoft.Json.Linq.JToken value = null;

            Console.WriteLine("The response contains the following videos:\n");

            // This example just prints the first page of videos. If you want to page
            // through the videos, set the offset query parameter to the next offset 
            // value that Bing returns.

            _nextOffset = (long)response["nextOffset"];

            var videos = response["value"] as Newtonsoft.Json.Linq.JToken;

            foreach (Newtonsoft.Json.Linq.JToken video in videos)
            {
                Console.WriteLine("Title: " + video["name"]);
                Console.WriteLine("Thumbnail: " + video["thumbnailUrl"]);
                Console.WriteLine("Thumbnail size: {0} (w) x {1} (h) ", video["thumbnail"]["width"], video["thumbnail"]["height"]);
                Console.WriteLine("Source video: " + video["contentUrl"]);
                Console.WriteLine("Source video size: {0} (w) x {1} (h) ", video["width"], video["height"]);
                Console.WriteLine("Publisher: " + GetPublisherString(video["publisher"]));

                if ((value = video["creator"]) != null)
                {
                    Console.WriteLine("Creator: " + (string)value["name"]);
                }

                // Always good to indicate how many people watched the video
                // on the source website, and how long the video is.

                if ((value = video["viewCount"]) != null)
                {
                    Console.WriteLine("Views: " + (long)value);
                }

                if ((value = video["duration"]) != null)
                {
                    TimeSpan ts = XmlConvert.ToTimeSpan((string)value);
                    Console.WriteLine("Length: " + ts.ToString());
                }

                // If the video includes the motionThumbnailUrl, use it to play
                // a preview of the video as the user hovers over the thumbnail.

                if ((value = video["motionThumbnailUrl"]) != null)
                {
                    Console.WriteLine("Motion thumbnail: " + (string)value);
                }

                if ((value = video["embedHtml"]) != null)
                {
                    Console.WriteLine("Embed HTML: " + (string)value);
                }

                Console.WriteLine();
            }
        }

        // Get a printable publisher string. The video's publisher field is an array
        // of publishers. In practice, there's a single publisher, but...

        static string GetPublisherString(Newtonsoft.Json.Linq.JToken publishers)
        {
            string publisherString = "";
            Boolean isFirst = true;

            foreach (Newtonsoft.Json.Linq.JToken publisher in publishers)
            {
                if (!isFirst)
                {
                    publisherString += " | ";
                }

                publisherString += publisher["name"];
            }

            return publisherString;
        }



        // Print any errors that occur. Depending on which part of the service is
        // throwing the error, the response may contain different formats.

        static void PrintErrors(HttpResponseHeaders headers, Dictionary<String, object> response)
        {
            Console.WriteLine("The response contains the following errors:\n");

            object value;

            if (response.TryGetValue("error", out value))  // typically 401, 403
            {
                PrintError(response["error"] as Newtonsoft.Json.Linq.JToken);
            }
            else if (response.TryGetValue("errors", out value))
            {
                // Bing API error

                foreach (Newtonsoft.Json.Linq.JToken error in response["errors"] as Newtonsoft.Json.Linq.JToken)
                {
                    PrintError(error);
                }

                // Included only when HTTP status code is 400; not included with 401 or 403.

                IEnumerable<string> headerValues;
                if (headers.TryGetValues("BingAPIs-TraceId", out headerValues))
                {
                    Console.WriteLine("\nTrace ID: " + headerValues.FirstOrDefault());
                }
            }

        }

        static void PrintError(Newtonsoft.Json.Linq.JToken error)
        {
            string value = null;

            Console.WriteLine("Code: " + error["code"]);
            Console.WriteLine("Message: " + error["message"]);

            if ((value = (string)error["parameter"]) != null)
            {
                Console.WriteLine("Parameter: " + value);
            }

            if ((value = (string)error["value"]) != null)
            {
                Console.WriteLine("Value: " + value);
            }
        }
    }
}
