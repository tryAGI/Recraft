
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Style { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid StyleId { get; set; }

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
        /// <param name="styleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BasicStyle(
            global::Recraft.TransformModel model,
            string style,
            global::System.Guid styleId)
        {
            this.Model = model;
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
            this.StyleId = styleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicStyle" /> class.
        /// </summary>
        public BasicStyle()
        {
        }
    }
}