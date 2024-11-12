
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
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public global::Recraft.ImageColor? BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("colors")]
        public global::System.Collections.Generic.IList<global::Recraft.ImageColor>? Colors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserControls" /> class.
        /// </summary>
        /// <param name="backgroundColor"></param>
        /// <param name="colors"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UserControls(
            global::Recraft.ImageColor? backgroundColor,
            global::System.Collections.Generic.IList<global::Recraft.ImageColor>? colors)
        {
            this.BackgroundColor = backgroundColor;
            this.Colors = colors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserControls" /> class.
        /// </summary>
        public UserControls()
        {
        }
    }
}