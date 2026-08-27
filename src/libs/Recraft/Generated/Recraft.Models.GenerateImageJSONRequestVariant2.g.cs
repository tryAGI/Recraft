
#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateImageJSONRequestVariant2
    {
        /// <summary>
        /// URLs or data URLs of style reference images. When provided, a style is created from these images and applied to the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_urls")]
        public global::System.Collections.Generic.IList<string>? StyleReferenceUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageJSONRequestVariant2" /> class.
        /// </summary>
        /// <param name="styleReferenceUrls">
        /// URLs or data URLs of style reference images. When provided, a style is created from these images and applied to the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageJSONRequestVariant2(
            global::System.Collections.Generic.IList<string>? styleReferenceUrls)
        {
            this.StyleReferenceUrls = styleReferenceUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageJSONRequestVariant2" /> class.
        /// </summary>
        public GenerateImageJSONRequestVariant2()
        {
        }

    }
}