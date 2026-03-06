
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorizeImageRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_reduction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ColorReductionJsonConverter))]
        public global::Recraft.ColorReduction? ColorReduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_num_shapes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.LimitNumShapesJsonConverter))]
        public global::Recraft.LimitNumShapes? LimitNumShapes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_shapes")]
        public int? MaxNumShapes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_gradients")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.ReturnGradientsJsonConverter))]
        public global::Recraft.ReturnGradients? ReturnGradients { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("small_shape_filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.SmallShapeFilterJsonConverter))]
        public global::Recraft.SmallShapeFilter? SmallShapeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("svg_compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recraft.JsonConverters.SvgCompressionJsonConverter))]
        public global::Recraft.SvgCompression? SvgCompression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorizeImageRequestVariant2" /> class.
        /// </summary>
        /// <param name="colorReduction"></param>
        /// <param name="limitNumShapes"></param>
        /// <param name="maxNumShapes"></param>
        /// <param name="returnGradients"></param>
        /// <param name="smallShapeFilter"></param>
        /// <param name="svgCompression"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorizeImageRequestVariant2(
            global::Recraft.ColorReduction? colorReduction,
            global::Recraft.LimitNumShapes? limitNumShapes,
            int? maxNumShapes,
            global::Recraft.ReturnGradients? returnGradients,
            global::Recraft.SmallShapeFilter? smallShapeFilter,
            global::Recraft.SvgCompression? svgCompression)
        {
            this.ColorReduction = colorReduction;
            this.LimitNumShapes = limitNumShapes;
            this.MaxNumShapes = maxNumShapes;
            this.ReturnGradients = returnGradients;
            this.SmallShapeFilter = smallShapeFilter;
            this.SvgCompression = svgCompression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorizeImageRequestVariant2" /> class.
        /// </summary>
        public VectorizeImageRequestVariant2()
        {
        }
    }
}