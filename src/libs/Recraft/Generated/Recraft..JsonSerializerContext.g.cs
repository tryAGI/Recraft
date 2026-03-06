
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Recraft.JsonConverters.TransformModelJsonConverter),
            typeof(global::Recraft.JsonConverters.TransformModelNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageStyleJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageStyleNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageSubStyleJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageSubStyleNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.BillingTypeJsonConverter),
            typeof(global::Recraft.JsonConverters.BillingTypeNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ColorReductionJsonConverter),
            typeof(global::Recraft.JsonConverters.ColorReductionNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.MixPolicyJsonConverter),
            typeof(global::Recraft.JsonConverters.MixPolicyNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageFormatJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageFormatNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ResponseFormatJsonConverter),
            typeof(global::Recraft.JsonConverters.ResponseFormatNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageSizeJsonConverter),
            typeof(global::Recraft.JsonConverters.ImageSizeNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.UpscaleModeJsonConverter),
            typeof(global::Recraft.JsonConverters.UpscaleModeNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.LimitNumShapesJsonConverter),
            typeof(global::Recraft.JsonConverters.LimitNumShapesNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.ReturnGradientsJsonConverter),
            typeof(global::Recraft.JsonConverters.ReturnGradientsNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.SmallShapeFilterJsonConverter),
            typeof(global::Recraft.JsonConverters.SmallShapeFilterNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.SvgCompressionJsonConverter),
            typeof(global::Recraft.JsonConverters.SvgCompressionNullableJsonConverter),
            typeof(global::Recraft.JsonConverters.CreateStyleResponseJsonConverter),
            typeof(global::Recraft.JsonConverters.TransformImageWithMaskRequestJsonConverter),
            typeof(global::Recraft.JsonConverters.VectorizeImageRequestJsonConverter),
            typeof(global::Recraft.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}