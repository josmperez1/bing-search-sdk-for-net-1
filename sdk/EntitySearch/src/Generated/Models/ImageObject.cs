// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.EntitySearch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines an image
    /// </summary>
    public partial class ImageObject : MediaObject
    {
        /// <summary>
        /// Initializes a new instance of the ImageObject class.
        /// </summary>
        public ImageObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageObject class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="contractualRules">A list of rules that you must adhere
        /// to if you display the item.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="name">The name of the thing represented by this
        /// object.</param>
        /// <param name="url">The URL to get more information about the thing
        /// represented by this object.</param>
        /// <param name="description">A short description of the item.</param>
        /// <param name="entityPresentationInfo">Additional information about
        /// the entity such as hints that you can use to determine the entity's
        /// type. To determine the entity's type, use the entityScenario and
        /// entityTypeHint fields.</param>
        /// <param name="bingId">An ID that uniquely identifies this
        /// item.</param>
        /// <param name="thumbnailUrl">The URL to a thumbnail of the
        /// item.</param>
        /// <param name="provider">The source of the creative work.</param>
        /// <param name="contentUrl">Original URL to retrieve the source (file)
        /// for the media object (e.g the source URL for the image).</param>
        /// <param name="hostPageUrl">URL of the page that hosts the media
        /// object.</param>
        /// <param name="width">The width of the source media object, in
        /// pixels.</param>
        /// <param name="height">The height of the source media object, in
        /// pixels.</param>
        /// <param name="thumbnail">The URL to a thumbnail of the image</param>
        public ImageObject(string _type = default(string), string id = default(string), IList<ContractualRulesContractualRule> contractualRules = default(IList<ContractualRulesContractualRule>), string webSearchUrl = default(string), string name = default(string), string url = default(string), ImageObject image = default(ImageObject), string description = default(string), EntitiesEntityPresentationInfo entityPresentationInfo = default(EntitiesEntityPresentationInfo), string bingId = default(string), string thumbnailUrl = default(string), IList<Thing> provider = default(IList<Thing>), string text = default(string), string contentUrl = default(string), string hostPageUrl = default(string), int? width = default(int?), int? height = default(int?), ImageObject thumbnail = default(ImageObject))
            : base(_type, id, contractualRules, webSearchUrl, name, url, image, description, entityPresentationInfo, bingId, thumbnailUrl, provider, text, contentUrl, hostPageUrl, width, height)
        {
            Thumbnail = thumbnail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the URL to a thumbnail of the image
        /// </summary>
        [JsonProperty(PropertyName = "thumbnail")]
        public ImageObject Thumbnail { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Thumbnail != null)
            {
                Thumbnail.Validate();
            }
        }
    }
}
