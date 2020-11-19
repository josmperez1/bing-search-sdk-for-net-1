// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.ImageSearch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a list of offers from merchants that are related to the image.
    /// </summary>
    public partial class AggregateOffer : Offer
    {
        /// <summary>
        /// Initializes a new instance of the AggregateOffer class.
        /// </summary>
        public AggregateOffer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AggregateOffer class.
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
        /// <param name="seller">Seller for this offer</param>
        /// <param name="price">The item's price.</param>
        /// <param name="priceCurrency">The monetary currency. For example,
        /// USD. Possible values include: 'USD', 'CAD', 'GBP', 'EUR', 'COP',
        /// 'JPY', 'CNY', 'AUD', 'INR', 'AED', 'AFN', 'ALL', 'AMD', 'ANG',
        /// 'AOA', 'ARS', 'AWG', 'AZN', 'BAM', 'BBD', 'BDT', 'BGN', 'BHD',
        /// 'BIF', 'BMD', 'BND', 'BOB', 'BOV', 'BRL', 'BSD', 'BTN', 'BWP',
        /// 'BYR', 'BZD', 'CDF', 'CHE', 'CHF', 'CHW', 'CLF', 'CLP', 'COU',
        /// 'CRC', 'CUC', 'CUP', 'CVE', 'CZK', 'DJF', 'DKK', 'DOP', 'DZD',
        /// 'EGP', 'ERN', 'ETB', 'FJD', 'FKP', 'GEL', 'GHS', 'GIP', 'GMD',
        /// 'GNF', 'GTQ', 'GYD', 'HKD', 'HNL', 'HRK', 'HTG', 'HUF', 'IDR',
        /// 'ILS', 'IQD', 'IRR', 'ISK', 'JMD', 'JOD', 'KES', 'KGS', 'KHR',
        /// 'KMF', 'KPW', 'KRW', 'KWD', 'KYD', 'KZT', 'LAK', 'LBP', 'LKR',
        /// 'LRD', 'LSL', 'LYD', 'MAD', 'MDL', 'MGA', 'MKD', 'MMK', 'MNT',
        /// 'MOP', 'MRO', 'MUR', 'MVR', 'MWK', 'MXN', 'MXV', 'MYR', 'MZN',
        /// 'NAD', 'NGN', 'NIO', 'NOK', 'NPR', 'NZD', 'OMR', 'PAB', 'PEN',
        /// 'PGK', 'PHP', 'PKR', 'PLN', 'PYG', 'QAR', 'RON', 'RSD', 'RUB',
        /// 'RWF', 'SAR', 'SBD', 'SCR', 'SDG', 'SEK', 'SGD', 'SHP', 'SLL',
        /// 'SOS', 'SRD', 'SSP', 'STD', 'SYP', 'SZL', 'THB', 'TJS', 'TMT',
        /// 'TND', 'TOP', 'TRY', 'TTD', 'TWD', 'TZS', 'UAH', 'UGX', 'UYU',
        /// 'UZS', 'VEF', 'VND', 'VUV', 'WST', 'XAF', 'XCD', 'XOF', 'XPF',
        /// 'YER', 'ZAR', 'ZMW'</param>
        /// <param name="availability">The item's availability. The following
        /// are the possible values: Discontinued, InStock, InStoreOnly,
        /// LimitedAvailability, OnlineOnly, OutOfStock, PreOrder, SoldOut.
        /// Possible values include: 'Discontinued', 'InStock', 'InStoreOnly',
        /// 'LimitedAvailability', 'OnlineOnly', 'OutOfStock', 'PreOrder',
        /// 'SoldOut'</param>
        /// <param name="aggregateRating">An aggregated rating that indicates
        /// how well the product has been rated by others.</param>
        /// <param name="lastUpdated">The last date that the offer was updated.
        /// The date is in the form YYYY-MM-DD.</param>
        /// <param name="offers">A list of offers from merchants that have
        /// offerings related to the image.</param>
        public AggregateOffer(string _type = default(string), string id = default(string), string readLink = default(string), string webSearchUrl = default(string), string name = default(string), string url = default(string), ImageObject image = default(ImageObject), string description = default(string), string alternateName = default(string), string bingId = default(string), Organization seller = default(Organization), double? price = default(double?), string priceCurrency = default(string), string availability = default(string), AggregateRating aggregateRating = default(AggregateRating), string lastUpdated = default(string), IList<Offer> offers = default(IList<Offer>))
            : base(_type, id, readLink, webSearchUrl, name, url, image, description, alternateName, bingId, seller, price, priceCurrency, availability, aggregateRating, lastUpdated)
        {
            Offers = offers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of offers from merchants that have offerings related to
        /// the image.
        /// </summary>
        [JsonProperty(PropertyName = "offers")]
        public IList<Offer> Offers { get; private set; }

    }
}
