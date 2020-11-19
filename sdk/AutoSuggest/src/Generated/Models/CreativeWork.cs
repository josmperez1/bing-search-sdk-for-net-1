// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.AutoSuggest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The most generic kind of creative work, including books, movies,
    /// photographs, software programs, etc.
    /// </summary>
    public partial class CreativeWork : Thing
    {
        /// <summary>
        /// Initializes a new instance of the CreativeWork class.
        /// </summary>
        public CreativeWork()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreativeWork class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="readLink">The URL that returns this resource.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="url">The URL to get more information about the thing
        /// represented by this object.</param>
        /// <param name="thumbnailUrl">The URL to a thumbnail of the
        /// item.</param>
        /// <param name="about">For internal use only.</param>
        /// <param name="mentions">For internal use only.</param>
        /// <param name="provider">The source of the creative work.</param>
        /// <param name="text">Text content of this creative work</param>
        public CreativeWork(string _type = default(string), string id = default(string), string readLink = default(string), string webSearchUrl = default(string), IList<Action> potentialAction = default(IList<Action>), IList<Action> immediateAction = default(IList<Action>), string preferredClickthroughUrl = default(string), string adaptiveCard = default(string), string url = default(string), string thumbnailUrl = default(string), IList<Thing> about = default(IList<Thing>), IList<Thing> mentions = default(IList<Thing>), IList<Thing> provider = default(IList<Thing>), Thing creator = default(Thing), string text = default(string), string discussionUrl = default(string), int? commentCount = default(int?), Thing mainEntity = default(Thing), string headLine = default(string), Thing copyrightHolder = default(Thing), int? copyrightYear = default(int?), string disclaimer = default(string), bool? isAccessibleForFree = default(bool?), IList<string> genre = default(IList<string>), bool? isFamilyFriendly = default(bool?))
            : base(_type, id, readLink, webSearchUrl, potentialAction, immediateAction, preferredClickthroughUrl, adaptiveCard, url)
        {
            ThumbnailUrl = thumbnailUrl;
            About = about;
            Mentions = mentions;
            Provider = provider;
            Creator = creator;
            Text = text;
            DiscussionUrl = discussionUrl;
            CommentCount = commentCount;
            MainEntity = mainEntity;
            HeadLine = headLine;
            CopyrightHolder = copyrightHolder;
            CopyrightYear = copyrightYear;
            Disclaimer = disclaimer;
            IsAccessibleForFree = isAccessibleForFree;
            Genre = genre;
            IsFamilyFriendly = isFamilyFriendly;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the URL to a thumbnail of the item.
        /// </summary>
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string ThumbnailUrl { get; private set; }

        /// <summary>
        /// Gets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "about")]
        public IList<Thing> About { get; private set; }

        /// <summary>
        /// Gets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "mentions")]
        public IList<Thing> Mentions { get; private set; }

        /// <summary>
        /// Gets the source of the creative work.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public IList<Thing> Provider { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "creator")]
        public Thing Creator { get; private set; }

        /// <summary>
        /// Gets text content of this creative work
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discussionUrl")]
        public string DiscussionUrl { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commentCount")]
        public int? CommentCount { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mainEntity")]
        public Thing MainEntity { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "headLine")]
        public string HeadLine { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "copyrightHolder")]
        public Thing CopyrightHolder { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "copyrightYear")]
        public int? CopyrightYear { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "disclaimer")]
        public string Disclaimer { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isAccessibleForFree")]
        public bool? IsAccessibleForFree { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "genre")]
        public IList<string> Genre { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isFamilyFriendly")]
        public bool? IsFamilyFriendly { get; private set; }

    }
}