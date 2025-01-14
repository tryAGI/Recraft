
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserControls
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artistic_level")]
        public int? ArtisticLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public global::Recraft.ImageColor? BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colors")]
        public global::System.Collections.Generic.IList<global::Recraft.ImageColor>? Colors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_text")]
        public bool? NoText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserControls" /> class.
        /// </summary>
        /// <param name="artisticLevel"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="colors"></param>
        /// <param name="noText"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UserControls(
            int? artisticLevel,
            global::Recraft.ImageColor? backgroundColor,
            global::System.Collections.Generic.IList<global::Recraft.ImageColor>? colors,
            bool? noText)
        {
            this.ArtisticLevel = artisticLevel;
            this.BackgroundColor = backgroundColor;
            this.Colors = colors;
            this.NoText = noText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserControls" /> class.
        /// </summary>
        public UserControls()
        {
        }
    }
}