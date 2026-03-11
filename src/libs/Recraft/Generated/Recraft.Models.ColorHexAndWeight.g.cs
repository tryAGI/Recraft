
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ColorHexAndWeight
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Hex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorHexAndWeight" /> class.
        /// </summary>
        /// <param name="hex"></param>
        /// <param name="weight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColorHexAndWeight(
            string hex,
            double? weight)
        {
            this.Hex = hex ?? throw new global::System.ArgumentNullException(nameof(hex));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorHexAndWeight" /> class.
        /// </summary>
        public ColorHexAndWeight()
        {
        }
    }
}