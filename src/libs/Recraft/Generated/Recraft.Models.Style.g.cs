
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Style(
            global::System.DateTime creationTime,
            global::System.Guid id,
            bool isPrivate,
            global::Recraft.ImageStyle style1)
        {
            this.CreationTime = creationTime;
            this.Id = id;
            this.IsPrivate = isPrivate;
            this.Style1 = style1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Style" /> class.
        /// </summary>
        public Style()
        {
        }

    }
}