
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutpaintImageRequestBaseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_bottom")]
        public int? ExpandBottom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_left")]
        public int? ExpandLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_right")]
        public int? ExpandRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_top")]
        public int? ExpandTop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ImageSizeJsonConverter))]
        public global::Recraft.ImageSize? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zoom_out_percentage")]
        public double? ZoomOutPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutpaintImageRequestBaseVariant2" /> class.
        /// </summary>
        /// <param name="expandBottom"></param>
        /// <param name="expandLeft"></param>
        /// <param name="expandRight"></param>
        /// <param name="expandTop"></param>
        /// <param name="size"></param>
        /// <param name="zoomOutPercentage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutpaintImageRequestBaseVariant2(
            int? expandBottom,
            int? expandLeft,
            int? expandRight,
            int? expandTop,
            global::Recraft.ImageSize? size,
            double? zoomOutPercentage)
        {
            this.ExpandBottom = expandBottom;
            this.ExpandLeft = expandLeft;
            this.ExpandRight = expandRight;
            this.ExpandTop = expandTop;
            this.Size = size;
            this.ZoomOutPercentage = zoomOutPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutpaintImageRequestBaseVariant2" /> class.
        /// </summary>
        public OutpaintImageRequestBaseVariant2()
        {
        }

    }
}