// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.microsoft.Bing.NewsSearch.Models
{
    using Newtonsoft.Json;
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
        public Thing(string _type = default(string), string id = default(string), string webSearchUrl = default(string), string name = default(string), string url = default(string), ImageObject image = default(ImageObject), string description = default(string), string alternateName = default(string), string bingId = default(string))
            : base(_type, id, webSearchUrl)
        {
            Name = name;
            Url = url;
            Image = image;
            Description = description;
            AlternateName = alternateName;
            BingId = bingId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the thing represented by this object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the URL to get more information about the thing represented by
        /// this object.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

        /// <summary>
        /// Gets an image of the item.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public ImageObject Image { get; private set; }

        /// <summary>
        /// Gets a short description of the item.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets an alias for the item
        /// </summary>
        [JsonProperty(PropertyName = "alternateName")]
        public string AlternateName { get; private set; }

        /// <summary>
        /// Gets an ID that uniquely identifies this item.
        /// </summary>
        [JsonProperty(PropertyName = "bingId")]
        public string BingId { get; private set; }

    }
}
