
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExploreSimilarRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_nsfw")]
        public bool? BlockNsfw { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ResponseFormatJsonConverter))]
        public global::Recraft.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Similarity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_image_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SourceImageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExploreSimilarRequest" /> class.
        /// </summary>
        /// <param name="blockNsfw"></param>
        /// <param name="expire"></param>
        /// <param name="imageFormat"></param>
        /// <param name="responseFormat"></param>
        /// <param name="similarity"></param>
        /// <param name="sourceImageId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExploreSimilarRequest(
            int similarity,
            global::System.Guid sourceImageId,
            bool? blockNsfw,
            bool? expire,
            global::Recraft.ImageFormat? imageFormat,
            global::Recraft.ResponseFormat? responseFormat)
        {
            this.Similarity = similarity;
            this.SourceImageId = sourceImageId;
            this.BlockNsfw = blockNsfw;
            this.Expire = expire;
            this.ImageFormat = imageFormat;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExploreSimilarRequest" /> class.
        /// </summary>
        public ExploreSimilarRequest()
        {
        }
    }
}