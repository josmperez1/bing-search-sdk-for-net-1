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
    /// Defines a news article.
    /// </summary>
    public partial class NewsArticle : Article
    {
        /// <summary>
        /// Initializes a new instance of the NewsArticle class.
        /// </summary>
        public NewsArticle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NewsArticle class.
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
        /// <param name="wordCount">The number of words in the text of the
        /// Article.</param>
        /// <param name="category">The news category that the article belongs
        /// to. For example, Sports. If the news category cannot be determined,
        /// the article does not include this field.</param>
        /// <param name="headline">A Boolean value that indicates whether the
        /// news article is a headline. If true, the article is a headline. The
        /// article includes this field only for news categories requests that
        /// do not specify the category query parameter.</param>
        /// <param name="clusteredArticles">A list of related news
        /// articles.</param>
        public NewsArticle(string _type = default(string), string id = default(string), string webSearchUrl = default(string), string name = default(string), string url = default(string), ImageObject image = default(ImageObject), string description = default(string), string alternateName = default(string), string bingId = default(string), string thumbnailUrl = default(string), IList<Thing> provider = default(IList<Thing>), string datePublished = default(string), VideoObject video = default(VideoObject), int? wordCount = default(int?), string category = default(string), bool? headline = default(bool?), IList<NewsArticle> clusteredArticles = default(IList<NewsArticle>))
            : base(_type, id, webSearchUrl, name, url, image, description, alternateName, bingId, thumbnailUrl, provider, datePublished, video, wordCount)
        {
            Category = category;
            Headline = headline;
            ClusteredArticles = clusteredArticles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the news category that the article belongs to. For example,
        /// Sports. If the news category cannot be determined, the article does
        /// not include this field.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; private set; }

        /// <summary>
        /// Gets a Boolean value that indicates whether the news article is a
        /// headline. If true, the article is a headline. The article includes
        /// this field only for news categories requests that do not specify
        /// the category query parameter.
        /// </summary>
        [JsonProperty(PropertyName = "headline")]
        public bool? Headline { get; private set; }

        /// <summary>
        /// Gets a list of related news articles.
        /// </summary>
        [JsonProperty(PropertyName = "clusteredArticles")]
        public IList<NewsArticle> ClusteredArticles { get; private set; }

    }
}
