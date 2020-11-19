// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bing.VideoSearch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for VideoInsightModule.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoInsightModule
    {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "RelatedVideos")]
        RelatedVideos,
        [EnumMember(Value = "VideoResult")]
        VideoResult
    }
    internal static class VideoInsightModuleEnumExtension
    {
        internal static string ToSerializedValue(this VideoInsightModule? value)
        {
            return value == null ? null : ((VideoInsightModule)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this VideoInsightModule value)
        {
            switch( value )
            {
                case VideoInsightModule.All:
                    return "All";
                case VideoInsightModule.RelatedVideos:
                    return "RelatedVideos";
                case VideoInsightModule.VideoResult:
                    return "VideoResult";
            }
            return null;
        }

        internal static VideoInsightModule? ParseVideoInsightModule(this string value)
        {
            switch( value )
            {
                case "All":
                    return VideoInsightModule.All;
                case "RelatedVideos":
                    return VideoInsightModule.RelatedVideos;
                case "VideoResult":
                    return VideoInsightModule.VideoResult;
            }
            return null;
        }
    }
}
