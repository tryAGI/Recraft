
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VariateImageRequestBase
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Recraft.ImageSize Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VariateImageRequestBase" /> class.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="expire"></param>
        /// <param name="imageFormat"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="randomSeed"></param>
        /// <param name="responseFormat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VariateImageRequestBase(
            global::Recraft.ImageSize size,
            bool? expire,
            global::Recraft.ImageFormat? imageFormat,
            global::Recraft.TransformModel? model,
            int? n,
            int? randomSeed,
            global::Recraft.ResponseFormat? responseFormat)
        {
            this.Expire = expire;
            this.ImageFormat = imageFormat;
            this.Model = model;
            this.N = n;
            this.RandomSeed = randomSeed;
            this.ResponseFormat = responseFormat;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VariateImageRequestBase" /> class.
        /// </summary>
        public VariateImageRequestBase()
        {
        }

    }
}