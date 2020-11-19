// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.CustomImageSearch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The most generic kind of creative work, including books, movies,
    /// photographs, software programs, etc.
    /// </summary>
    public partial class CreativeWork : Thing
    {
        /// <summary>
        /// Initializes a new instance of the CreativeWork class.
        /// </summary>
        public CreativeWork()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreativeWork class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="readLink">The URL that returns this resource.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="name">The name of the thing represented by this
        /// object.</param>
        /// <param name="url">The URL to get more information about the thing
        /// represented by this object.</param>
        /// <param name="image">An image of the item.</param>
        /// <param name="description">A short description of the item.</param>
        /// <param name="alternateName">An alias for the item</param>
        /// <param name="bingId">An ID that uniquely identifies this
        /// item.</param>
        /// <param name="thumbnailUrl">The URL to a thumbnail of the
        /// item.</param>
        /// <param name="provider">The source of the creative work.</param>
        /// <param name="text">Text content of this creative work</param>
        public CreativeWork(string _type = default(string), string id = default(string), string readLink = default(string), string webSearchUrl = default(string), string name = default(string), string url = default(string), ImageObject image = default(ImageObject), string description = default(string), string alternateName = default(string), string bingId = default(string), string thumbnailUrl = default(string), IList<Thing> provider = default(IList<Thing>), string text = default(string))
            : base(_type, id, readLink, webSearchUrl, name, url, image, description, alternateName, bingId)
        {
            ThumbnailUrl = thumbnailUrl;
            Provider = provider;
            Text = text;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the URL to a thumbnail of the item.
        /// </summary>
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string ThumbnailUrl { get; private set; }

        /// <summary>
        /// Gets the source of the creative work.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public IList<Thing> Provider { get; private set; }

        /// <summary>
        /// Gets text content of this creative work
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; private set; }

    }
}
