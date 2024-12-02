
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BasicStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.TransformModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Recraft.TransformModel Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ImageStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Recraft.ImageStyle Style { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("substyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ImageSubStyleJsonConverter))]
        public global::Recraft.ImageSubStyle? Substyle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicStyle" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="style"></param>
        /// <param name="substyle"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BasicStyle(
            global::Recraft.TransformModel model,
            global::Recraft.ImageStyle style,
            global::Recraft.ImageSubStyle? substyle)
        {
            this.Model = model;
            this.Style = style;
            this.Substyle = substyle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicStyle" /> class.
        /// </summary>
        public BasicStyle()
        {
        }
    }
}