// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.AutoSuggest.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the error that occurred.
    /// </summary>
    public partial class Error
    {
        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        /// <param name="code">The error code that identifies the category of
        /// error. Possible values include: 'None', 'ServerError',
        /// 'InvalidRequest', 'RateLimitExceeded', 'InvalidAuthorization',
        /// 'InsufficientAuthorization'</param>
        /// <param name="message">A description of the error.</param>
        /// <param name="moreDetails">A description that provides additional
        /// information about the error.</param>
        /// <param name="parameter">The parameter in the request that caused
        /// the error.</param>
        /// <param name="value">The parameter's value in the request that was
        /// not valid.</param>
        public Error(string code, string message, string moreDetails = default(string), string parameter = default(string), string value = default(string), string _type = default(string))
        {
            Code = code;
            Message = message;
            MoreDetails = moreDetails;
            Parameter = parameter;
            Value = value;
            this._type = _type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the error code that identifies the category of error.
        /// Possible values include: 'None', 'ServerError', 'InvalidRequest',
        /// 'RateLimitExceeded', 'InvalidAuthorization',
        /// 'InsufficientAuthorization'
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a description of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets a description that provides additional information about the
        /// error.
        /// </summary>
        [JsonProperty(PropertyName = "moreDetails")]
        public string MoreDetails { get; private set; }

        /// <summary>
        /// Gets the parameter in the request that caused the error.
        /// </summary>
        [JsonProperty(PropertyName = "parameter")]
        public string Parameter { get; private set; }

        /// <summary>
        /// Gets the parameter's value in the request that was not valid.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_type")]
        public string _type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
        }
    }
}
