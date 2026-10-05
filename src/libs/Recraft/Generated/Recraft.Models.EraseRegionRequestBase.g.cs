
#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EraseRegionRequestBase
    {
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
        /// Zero data retention: the prompt and the input and output image bytes are neither stored nor logged; only an output requested as a URL is uploaded so it can be served.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zdr")]
        public bool? Zdr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EraseRegionRequestBase" /> class.
        /// </summary>
        /// <param name="imageFormat"></param>
        /// <param name="responseFormat"></param>
        /// <param name="zdr">
        /// Zero data retention: the prompt and the input and output image bytes are neither stored nor logged; only an output requested as a URL is uploaded so it can be served.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EraseRegionRequestBase(
            global::Recraft.ImageFormat? imageFormat,
            global::Recraft.ResponseFormat? responseFormat,
            bool? zdr)
        {
            this.ImageFormat = imageFormat;
            this.ResponseFormat = responseFormat;
            this.Zdr = zdr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EraseRegionRequestBase" /> class.
        /// </summary>
        public EraseRegionRequestBase()
        {
        }

    }
}