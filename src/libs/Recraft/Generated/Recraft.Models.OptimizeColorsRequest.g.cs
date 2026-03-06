
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizeColorsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Recraft.ColorHexAndWeight> Colors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_colors_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumColorsLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizeColorsRequest" /> class.
        /// </summary>
        /// <param name="colors"></param>
        /// <param name="numColorsLimit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptimizeColorsRequest(
            global::System.Collections.Generic.IList<global::Recraft.ColorHexAndWeight> colors,
            int numColorsLimit)
        {
            this.Colors = colors ?? throw new global::System.ArgumentNullException(nameof(colors));
            this.NumColorsLimit = numColorsLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizeColorsRequest" /> class.
        /// </summary>
        public OptimizeColorsRequest()
        {
        }
    }
}