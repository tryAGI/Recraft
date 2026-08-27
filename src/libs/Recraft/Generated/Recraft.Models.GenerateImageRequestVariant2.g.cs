
#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateImageRequestVariant2
    {
        /// <summary>
        /// Style reference images. When provided, a style is created from these images and applied to the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_references")]
        public global::System.Collections.Generic.IList<byte[]>? StyleReferences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestVariant2" /> class.
        /// </summary>
        /// <param name="styleReferences">
        /// Style reference images. When provided, a style is created from these images and applied to the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequestVariant2(
            global::System.Collections.Generic.IList<byte[]>? styleReferences)
        {
            this.StyleReferences = styleReferences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestVariant2" /> class.
        /// </summary>
        public GenerateImageRequestVariant2()
        {
        }

    }
}