
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToImageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_nsfw")]
        public bool? BlockNsfw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculate_features")]
        public bool? CalculateFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        public global::Recraft.UserControls? Controls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Strength { get; set; }

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
        /// Initializes a new instance of the <see cref="ImageToImageRequest" /> class.
        /// </summary>
        /// <param name="blockNsfw"></param>
        /// <param name="calculateFeatures"></param>
        /// <param name="controls"></param>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="prompt"></param>
        /// <param name="randomSeed"></param>
        /// <param name="responseFormat"></param>
        /// <param name="strength"></param>
        /// <param name="style"></param>
        /// <param name="styleId"></param>
        /// <param name="substyle"></param>
        /// <param name="textLayout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToImageRequest(
            byte[] image,
            string imagename,
            string prompt,
            double strength,
            bool? blockNsfw,
            bool? calculateFeatures,
            global::Recraft.UserControls? controls,
            global::Recraft.TransformModel? model,
            int? n,
            string? negativePrompt,
            int? randomSeed,
            global::Recraft.ResponseFormat? responseFormat,
            global::Recraft.ImageStyle? style,
            global::System.Guid? styleId,
            global::Recraft.ImageSubStyle? substyle,
            global::System.Collections.Generic.IList<global::Recraft.TextLayoutItem>? textLayout)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Strength = strength;
            this.BlockNsfw = blockNsfw;
            this.CalculateFeatures = calculateFeatures;
            this.Controls = controls;
            this.Model = model;
            this.N = n;
            this.NegativePrompt = negativePrompt;
            this.RandomSeed = randomSeed;
            this.ResponseFormat = responseFormat;
            this.Style = style;
            this.StyleId = styleId;
            this.Substyle = substyle;
            this.TextLayout = textLayout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageRequest" /> class.
        /// </summary>
        public ImageToImageRequest()
        {
        }
    }
}