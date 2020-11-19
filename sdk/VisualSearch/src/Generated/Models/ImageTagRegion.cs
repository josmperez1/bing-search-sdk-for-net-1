// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.VisualSearch.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines an image region relevant to the ImageTag.
    /// </summary>
    public partial class ImageTagRegion
    {
        /// <summary>
        /// Initializes a new instance of the ImageTagRegion class.
        /// </summary>
        public ImageTagRegion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageTagRegion class.
        /// </summary>
        /// <param name="queryRectangle">A rectangle that outlines the area of
        /// interest for this tag.</param>
        /// <param name="displayRectangle">A recommended rectangle to show to
        /// the user.</param>
        public ImageTagRegion(NormalizedQuadrilateral queryRectangle, NormalizedQuadrilateral displayRectangle)
        {
            QueryRectangle = queryRectangle;
            DisplayRectangle = displayRectangle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a rectangle that outlines the area of interest for
        /// this tag.
        /// </summary>
        [JsonProperty(PropertyName = "queryRectangle")]
        public NormalizedQuadrilateral QueryRectangle { get; set; }

        /// <summary>
        /// Gets or sets a recommended rectangle to show to the user.
        /// </summary>
        [JsonProperty(PropertyName = "displayRectangle")]
        public NormalizedQuadrilateral DisplayRectangle { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (QueryRectangle == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "QueryRectangle");
            }
            if (DisplayRectangle == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayRectangle");
            }
            if (QueryRectangle != null)
            {
                QueryRectangle.Validate();
            }
            if (DisplayRectangle != null)
            {
                DisplayRectangle.Validate();
            }
        }
    }
}
