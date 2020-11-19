// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.VisualSearch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a list of recipes.
    /// </summary>
    public partial class RecipesModule
    {
        /// <summary>
        /// Initializes a new instance of the RecipesModule class.
        /// </summary>
        public RecipesModule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecipesModule class.
        /// </summary>
        /// <param name="value">A list of recipes.</param>
        public RecipesModule(IList<Recipe> value = default(IList<Recipe>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of recipes.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Recipe> Value { get; private set; }

    }
}
