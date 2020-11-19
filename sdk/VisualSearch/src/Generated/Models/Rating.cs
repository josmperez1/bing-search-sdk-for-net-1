// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.VisualSearch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines a rating.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Rating")]
    public partial class Rating : PropertiesItem
    {
        /// <summary>
        /// Initializes a new instance of the Rating class.
        /// </summary>
        public Rating()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Rating class.
        /// </summary>
        /// <param name="ratingValue">The mean (average) rating. The possible
        /// values are 1.0 through 5.0.</param>
        /// <param name="text">Text representation of an item.</param>
        /// <param name="bestRating">The highest rated review. The possible
        /// values are 1.0 through 5.0.</param>
        public Rating(double ratingValue, string text = default(string), double? bestRating = default(double?))
            : base(text)
        {
            RatingValue = ratingValue;
            BestRating = bestRating;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the mean (average) rating. The possible values are 1.0
        /// through 5.0.
        /// </summary>
        [JsonProperty(PropertyName = "ratingValue")]
        public double RatingValue { get; set; }

        /// <summary>
        /// Gets the highest rated review. The possible values are 1.0 through
        /// 5.0.
        /// </summary>
        [JsonProperty(PropertyName = "bestRating")]
        public double? BestRating { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}