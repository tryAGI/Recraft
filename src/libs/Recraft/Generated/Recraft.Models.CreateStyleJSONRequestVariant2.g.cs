
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStyleJSONRequestVariant2
    {
        /// <summary>
        /// URLs or data URLs of the input images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ImageUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleJSONRequestVariant2" /> class.
        /// </summary>
        /// <param name="imageUrls">
        /// URLs or data URLs of the input images.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStyleJSONRequestVariant2(
            global::System.Collections.Generic.IList<string> imageUrls)
        {
            this.ImageUrls = imageUrls ?? throw new global::System.ArgumentNullException(nameof(imageUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleJSONRequestVariant2" /> class.
        /// </summary>
        public CreateStyleJSONRequestVariant2()
        {
        }

    }
}