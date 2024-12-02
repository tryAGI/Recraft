
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        public global::Recraft.UserControls? Controls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.TransformModelJsonConverter))]
        public global::Recraft.TransformModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("random_seed")]
        public int? RandomSeed { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ImageStyleJsonConverter))]
        public global::Recraft.ImageStyle? Style { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_layout")]
        public global::System.Collections.Generic.IList<global::Recraft.TextLayoutItem>? TextLayout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="prompt"></param>
        /// <param name="randomSeed"></param>
        /// <param name="responseFormat"></param>
        /// <param name="size"></param>
        /// <param name="style"></param>
        /// <param name="styleId"></param>
        /// <param name="substyle"></param>
        /// <param name="textLayout"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GenerateImageRequest(
            string prompt,
            global::Recraft.UserControls? controls,
            global::Recraft.TransformModel? model,
            int? n,
            int? randomSeed,
            global::Recraft.ResponseFormat? responseFormat,
            global::Recraft.ImageSize? size,
            global::Recraft.ImageStyle? style,
            global::System.Guid? styleId,
            global::Recraft.ImageSubStyle? substyle,
            global::System.Collections.Generic.IList<global::Recraft.TextLayoutItem>? textLayout)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Controls = controls;
            this.Model = model;
            this.N = n;
            this.RandomSeed = randomSeed;
            this.ResponseFormat = responseFormat;
            this.Size = size;
            this.Style = style;
            this.StyleId = styleId;
            this.Substyle = substyle;
            this.TextLayout = textLayout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        public GenerateImageRequest()
        {
        }
    }
}