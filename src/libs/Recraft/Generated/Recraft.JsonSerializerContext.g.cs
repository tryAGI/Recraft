
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
            typeof(global::Recraft.JsonConverters.ColorReductionJsonConverter),

            typeof(global::Recraft.JsonConverters.ColorReductionNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.ImageFormatJsonConverter),

            typeof(global::Recraft.JsonConverters.ImageFormatNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.ImageSizeJsonConverter),

            typeof(global::Recraft.JsonConverters.ImageSizeNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.ImageStyleJsonConverter),

            typeof(global::Recraft.JsonConverters.ImageStyleNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.LimitNumShapesJsonConverter),

            typeof(global::Recraft.JsonConverters.LimitNumShapesNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.MixPolicyJsonConverter),

            typeof(global::Recraft.JsonConverters.MixPolicyNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.ResponseFormatJsonConverter),

            typeof(global::Recraft.JsonConverters.ResponseFormatNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.ReturnGradientsJsonConverter),

            typeof(global::Recraft.JsonConverters.ReturnGradientsNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.ShapeStackingJsonConverter),

            typeof(global::Recraft.JsonConverters.ShapeStackingNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.SmallShapeFilterJsonConverter),

            typeof(global::Recraft.JsonConverters.SmallShapeFilterNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.StyleMatchJsonConverter),

            typeof(global::Recraft.JsonConverters.StyleMatchNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.SvgCompressionJsonConverter),

            typeof(global::Recraft.JsonConverters.SvgCompressionNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.TransformModelJsonConverter),

            typeof(global::Recraft.JsonConverters.TransformModelNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.UpscaleModeJsonConverter),

            typeof(global::Recraft.JsonConverters.UpscaleModeNullableJsonConverter),

            typeof(global::Recraft.JsonConverters.CreateStyleRequestJsonConverter),

            typeof(global::Recraft.JsonConverters.CreateStyleResponseJsonConverter),

            typeof(global::Recraft.JsonConverters.EraseRegionRequestJsonConverter),

            typeof(global::Recraft.JsonConverters.GenerateImageRequestJsonConverter),

            typeof(global::Recraft.JsonConverters.ImageToImageRequestJsonConverter),

            typeof(global::Recraft.JsonConverters.OutpaintImageRequestJsonConverter),

            typeof(global::Recraft.JsonConverters.OutpaintImageRequestBaseJsonConverter),

            typeof(global::Recraft.JsonConverters.ProcessImageRequestJsonConverter),

            typeof(global::Recraft.JsonConverters.TransformImageRequestJsonConverter),

            typeof(global::Recraft.JsonConverters.TransformImageWithMaskRequestJsonConverter),

            typeof(global::Recraft.JsonConverters.VariateImageRequestJsonConverter),

            typeof(global::Recraft.JsonConverters.VectorizeImageRequestJsonConverter),

            typeof(global::Recraft.JsonConverters.VectorizeImageRequestBaseJsonConverter),

            typeof(global::Recraft.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.BasicStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.TransformModel), TypeInfoPropertyName = "TransformModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ColorReduction), TypeInfoPropertyName = "ColorReduction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.CreateStyleRequest), TypeInfoPropertyName = "CreateStyleRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.CreateStyleRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.CreateStyleRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.StyleMatch), TypeInfoPropertyName = "StyleMatch2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.MixPolicy), TypeInfoPropertyName = "MixPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.PaletteSuggest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ImageStyle), TypeInfoPropertyName = "ImageStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.CreateStyleResponse), TypeInfoPropertyName = "CreateStyleResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.Style))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.CreateStyleResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.EraseRegionRequest), TypeInfoPropertyName = "EraseRegionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.EraseRegionRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.EraseRegionRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ImageFormat), TypeInfoPropertyName = "ImageFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ResponseFormat), TypeInfoPropertyName = "ResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.GenerateImageRequest), TypeInfoPropertyName = "GenerateImageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.GenerateImageRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.GenerateImageRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.UserControls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ImageSize), TypeInfoPropertyName = "ImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recraft.TextLayoutItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.UpscaleMode), TypeInfoPropertyName = "UpscaleMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.GenerateImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recraft.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ImageColor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ImageToImageRequest), TypeInfoPropertyName = "ImageToImageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.TransformImageRequest), TypeInfoPropertyName = "TransformImageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ImageToImageRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.LimitNumShapes), TypeInfoPropertyName = "LimitNumShapes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ListBasicStylesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recraft.BasicStyle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ListStylesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recraft.Style>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.OutpaintImageRequest), TypeInfoPropertyName = "OutpaintImageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.OutpaintImageRequestBase), TypeInfoPropertyName = "OutpaintImageRequestBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.OutpaintImageRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.TransformImageRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.OutpaintImageRequestBaseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recraft.ImageColor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ProcessImageRequest), TypeInfoPropertyName = "ProcessImageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ProcessImageRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ProcessImageRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ProcessImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ReturnGradients), TypeInfoPropertyName = "ReturnGradients2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.ShapeStacking), TypeInfoPropertyName = "ShapeStacking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.SmallShapeFilter), TypeInfoPropertyName = "SmallShapeFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.SvgCompression), TypeInfoPropertyName = "SvgCompression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.TextLayoutItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.TransformImageRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.TransformImageWithMaskRequest), TypeInfoPropertyName = "TransformImageWithMaskRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.TransformImageWithMaskRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.VariateImageRequest), TypeInfoPropertyName = "VariateImageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.VariateImageRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.VariateImageRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.VectorizeImageRequest), TypeInfoPropertyName = "VectorizeImageRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.VectorizeImageRequestBase), TypeInfoPropertyName = "VectorizeImageRequestBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.VectorizeImageRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recraft.VectorizeImageRequestBaseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recraft.TextLayoutItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recraft.Image>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recraft.BasicStyle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recraft.Style>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recraft.ImageColor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}