
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsfw_score")]
        public double? NsfwScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFeatures" /> class.
        /// </summary>
        /// <param name="nsfwScore"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImageFeatures(
            double? nsfwScore)
        {
            this.NsfwScore = nsfwScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFeatures" /> class.
        /// </summary>
        public ImageFeatures()
        {
        }
    }
}