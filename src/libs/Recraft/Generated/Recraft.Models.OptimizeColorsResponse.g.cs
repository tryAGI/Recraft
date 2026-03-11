
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizeColorsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Recraft.ColorMapping> Mapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizeColorsResponse" /> class.
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="mapping"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptimizeColorsResponse(
            int credits,
            global::System.Collections.Generic.IList<global::Recraft.ColorMapping> mapping)
        {
            this.Credits = credits;
            this.Mapping = mapping ?? throw new global::System.ArgumentNullException(nameof(mapping));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizeColorsResponse" /> class.
        /// </summary>
        public OptimizeColorsResponse()
        {
        }
    }
}