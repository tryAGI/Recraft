
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VariateImageRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VariateImageRequestVariant2" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VariateImageRequestVariant2(
            byte[]? image,
            string? imagename)
        {
            this.Image = image;
            this.Imagename = imagename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VariateImageRequestVariant2" /> class.
        /// </summary>
        public VariateImageRequestVariant2()
        {
        }

    }
}