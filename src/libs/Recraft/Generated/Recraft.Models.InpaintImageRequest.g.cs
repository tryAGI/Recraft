
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InpaintImageRequest
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Mask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Maskname { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintImageRequest" /> class.
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="mask"></param>
        /// <param name="maskname"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="prompt"></param>
        /// <param name="randomSeed"></param>
        /// <param name="responseFormat"></param>
        /// <param name="style"></param>
        /// <param name="styleId"></param>
        /// <param name="substyle"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public InpaintImageRequest(
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            string prompt,
            global::Recraft.UserControls? controls,
            global::Recraft.TransformModel? model,
            int? n,
            int? randomSeed,
            global::Recraft.ResponseFormat? responseFormat,
            global::Recraft.ImageStyle? style,
            global::System.Guid? styleId,
            global::Recraft.ImageSubStyle? substyle)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.Maskname = maskname ?? throw new global::System.ArgumentNullException(nameof(maskname));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Controls = controls;
            this.Model = model;
            this.N = n;
            this.RandomSeed = randomSeed;
            this.ResponseFormat = responseFormat;
            this.Style = style;
            this.StyleId = styleId;
            this.Substyle = substyle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintImageRequest" /> class.
        /// </summary>
        public InpaintImageRequest()
        {
        }
    }
}