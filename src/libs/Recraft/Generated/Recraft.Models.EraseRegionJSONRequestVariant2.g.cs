
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EraseRegionJSONRequestVariant2
    {
        /// <summary>
        /// URL or data URL of the input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// URL or data URL of the mask image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MaskUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EraseRegionJSONRequestVariant2" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// URL or data URL of the input image.
        /// </param>
        /// <param name="maskUrl">
        /// URL or data URL of the mask image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EraseRegionJSONRequestVariant2(
            string imageUrl,
            string maskUrl)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.MaskUrl = maskUrl ?? throw new global::System.ArgumentNullException(nameof(maskUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EraseRegionJSONRequestVariant2" /> class.
        /// </summary>
        public EraseRegionJSONRequestVariant2()
        {
        }

    }
}