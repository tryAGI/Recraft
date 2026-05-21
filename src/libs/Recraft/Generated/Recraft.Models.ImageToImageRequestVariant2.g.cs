
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToImageRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Strength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageRequestVariant2" /> class.
        /// </summary>
        /// <param name="strength"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToImageRequestVariant2(
            double strength)
        {
            this.Strength = strength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageRequestVariant2" /> class.
        /// </summary>
        public ImageToImageRequestVariant2()
        {
        }

    }
}