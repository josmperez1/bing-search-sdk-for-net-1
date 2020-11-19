// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.ImageSearch
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// The Image Search API lets you send a search query to Bing and get back
    /// a list of relevant images. This section provides technical details
    /// about the query parameters and headers that you use to request images
    /// and the JSON response objects that contain them. For examples that show
    /// how to make requests, see [Searching the Web for
    /// Images](https://docs.microsoft.com/en-us/bing/bing-image-search/overview).
    /// </summary>
    public partial interface IImageSearchClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IImagesOperations.
        /// </summary>
        IImagesOperations Images { get; }

    }
}
