
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Style
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPrivate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ImageStyleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Recraft.ImageStyle Style1 { get; set; }

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
        /// Initializes a new instance of the <see cref="Style" /> class.
        /// </summary>
        /// <param name="creationTime"></param>
        /// <param name="id"></param>
        /// <param name="isPrivate"></param>
        /// <param name="style1"></param>
        /// <param name="substyle"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Style(
            global::System.DateTime creationTime,
            global::System.Guid id,
            bool isPrivate,
            global::Recraft.ImageStyle style1,
            global::Recraft.ImageSubStyle? substyle)
        {
            this.CreationTime = creationTime;
            this.Id = id;
            this.IsPrivate = isPrivate;
            this.Style1 = style1;
            this.Substyle = substyle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Style" /> class.
        /// </summary>
        public Style()
        {
        }
    }
}