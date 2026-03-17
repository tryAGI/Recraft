
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExploreRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_nsfw")]
        public bool? BlockNsfw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        public global::Recraft.UserControls? Controls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expire")]
        public bool? Expire { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ImageFormatJsonConverter))]
        public global::Recraft.ImageFormat? ImageFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.TransformModelJsonConverter))]
        public global::Recraft.TransformModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ResponseFormatJsonConverter))]
        public global::Recraft.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ImageSizeJsonConverter))]
        public global::Recraft.ImageSize? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_id")]
        public global::System.Guid? StyleId { get; set; }

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
        /// Initializes a new instance of the <see cref="ExploreRequest" /> class.
        /// </summary>
        /// <param name="blockNsfw"></param>
        /// <param name="controls"></param>
        /// <param name="expire"></param>
        /// <param name="imageFormat"></param>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="responseFormat"></param>
        /// <param name="size"></param>
        /// <param name="style"></param>
        /// <param name="styleId"></param>
        /// <param name="substyle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExploreRequest(
            string prompt,
            bool? blockNsfw,
            global::Recraft.UserControls? controls,
            bool? expire,
            global::Recraft.ImageFormat? imageFormat,
            global::Recraft.TransformModel? model,
            global::Recraft.ResponseFormat? responseFormat,
            global::Recraft.ImageSize? size,
            string? style,
            global::System.Guid? styleId,
            global::Recraft.ImageSubStyle? substyle)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.BlockNsfw = blockNsfw;
            this.Controls = controls;
            this.Expire = expire;
            this.ImageFormat = imageFormat;
            this.Model = model;
            this.ResponseFormat = responseFormat;
            this.Size = size;
            this.Style = style;
            this.StyleId = styleId;
            this.Substyle = substyle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExploreRequest" /> class.
        /// </summary>
        public ExploreRequest()
        {
        }
    }
}