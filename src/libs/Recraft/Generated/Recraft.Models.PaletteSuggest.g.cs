
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaletteSuggest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public global::Recraft.ImageColor? BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Recraft.ImageColor> Colors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaletteSuggest" /> class.
        /// </summary>
        /// <param name="backgroundColor"></param>
        /// <param name="colors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaletteSuggest(
            global::System.Collections.Generic.IList<global::Recraft.ImageColor> colors,
            global::Recraft.ImageColor? backgroundColor)
        {
            this.Colors = colors ?? throw new global::System.ArgumentNullException(nameof(colors));
            this.BackgroundColor = backgroundColor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaletteSuggest" /> class.
        /// </summary>
        public PaletteSuggest()
        {
        }
    }
}