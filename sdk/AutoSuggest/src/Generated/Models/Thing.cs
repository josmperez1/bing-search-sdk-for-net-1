// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.AutoSuggest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a thing.
    /// </summary>
    public partial class Thing : Response
    {
        /// <summary>
        /// Initializes a new instance of the Thing class.
        /// </summary>
        public Thing()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Thing class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="readLink">The URL that returns this resource.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="url">The URL to get more information about the thing
        /// represented by this object.</param>
        public Thing(string _type = default(string), string id = default(string), string readLink = default(string), string webSearchUrl = default(string), IList<Action> potentialAction = default(IList<Action>), IList<Action> immediateAction = default(IList<Action>), string preferredClickthroughUrl = default(string), string adaptiveCard = default(string), string url = default(string))
            : base(_type, id, readLink, webSearchUrl, potentialAction, immediateAction, preferredClickthroughUrl, adaptiveCard)
        {
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the URL to get more information about the thing represented by
        /// this object.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

    }
}
