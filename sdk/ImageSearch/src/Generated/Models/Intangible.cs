// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.ImageSearch.Models
{
    using System.Linq;

    /// <summary>
    /// A utility class that serves as the umbrella for a number of
    /// 'intangible' things such as quantities, structured values, etc.
    /// </summary>
    public partial class Intangible : Thing
    {
        /// <summary>
        /// Initializes a new instance of the Intangible class.
        /// </summary>
        public Intangible()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Intangible class.
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
        public Intangible(string _type = default(string), string id = default(string), string readLink = default(string), string webSearchUrl = default(string), string name = default(string), string url = default(string), ImageObject image = default(ImageObject), string description = default(string), string alternateName = default(string), string bingId = default(string))
            : base(_type, id, readLink, webSearchUrl, name, url, image, description, alternateName, bingId)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
