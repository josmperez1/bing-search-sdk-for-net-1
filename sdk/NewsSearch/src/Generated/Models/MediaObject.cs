// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.microsoft.Bing.NewsSearch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a media object.
    /// </summary>
    public partial class MediaObject : CreativeWork
    {
        /// <summary>
        /// Initializes a new instance of the MediaObject class.
        /// </summary>
        public MediaObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaObject class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
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
        /// <param name="datePublished">The date on which the CreativeWork was
        /// published.</param>
        /// <param name="video">A video of the item.</param>
        /// <param name="contentUrl">Original URL to retrieve the source (file)
        /// for the media object (e.g the source URL for the image).</param>
        /// <param name="width">The width of the source media object, in
        /// pixels.</param>
        /// <param name="height">The height of the source media object, in
        /// pixels.</param>
        public MediaObject(string _type = default(string), string id = default(string), string webSearchUrl = default(string), string name = default(string), string url = default(string), ImageObject image = default(ImageObject), string description = default(string), string alternateName = default(string), string bingId = default(string), string thumbnailUrl = default(string), IList<Thing> provider = default(IList<Thing>), string datePublished = default(string), VideoObject video = default(VideoObject), string contentUrl = default(string), int? width = default(int?), int? height = default(int?))
            : base(_type, id, webSearchUrl, name, url, image, description, alternateName, bingId, thumbnailUrl, provider, datePublished, video)
        {
            ContentUrl = contentUrl;
            Width = width;
            Height = height;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets original URL to retrieve the source (file) for the media
        /// object (e.g the source URL for the image).
        /// </summary>
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; private set; }

        /// <summary>
        /// Gets the width of the source media object, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; private set; }

        /// <summary>
        /// Gets the height of the source media object, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; private set; }

    }
}
