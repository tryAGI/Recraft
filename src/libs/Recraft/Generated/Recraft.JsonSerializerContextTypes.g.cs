
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Recraft.BasicStyle? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TransformModel? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ColorReduction? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.CreateStyleJSONRequest? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.CreateStyleRequestBase? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.CreateStyleJSONRequestVariant2? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.CreateStyleRequest? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.CreateStyleRequestVariant2? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.StyleMatch? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.MixPolicy? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.PaletteSuggest? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ImageStyle? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.CreateStyleResponse? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.Style? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.CreateStyleResponseVariant2? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EnhanceImageJSONRequest? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EnhanceImageRequestBase? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EnhanceImageJSONRequestVariant2? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EnhanceImageRequest? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EnhanceImageRequestVariant2? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ImageFormat? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EnhanceMode? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ResponseFormat? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EraseRegionJSONRequest? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EraseRegionRequestBase? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EraseRegionJSONRequestVariant2? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EraseRegionRequest? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.EraseRegionRequestVariant2? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ExternalApiVectorizerVersion? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.GenerateImageJSONRequest? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.GenerateImageRequestBase? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.GenerateImageJSONRequestVariant2? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.GenerateImageMultipartResponse? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.GenerateImageResponse? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.GenerateImageRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.GenerateImageRequestVariant2? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.UserControls? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ImageSize? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recraft.TextLayoutItem>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.UpscaleMode? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recraft.Image>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.Image? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ImageColor? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ImageToImageJSONRequest? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TransformImageJSONRequest? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ImageToImageJSONRequestVariant2? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ImageToImageRequest? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TransformImageRequest? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ImageToImageRequestVariant2? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.LimitNumShapes? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ListBasicStylesResponse? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recraft.BasicStyle>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ListStylesResponse? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recraft.Style>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.OutpaintImageJSONRequest? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.OutpaintImageRequestBase? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.OutpaintImageRequest? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.OutpaintImageRequestVariant2? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TransformImageRequestBase? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.OutpaintImageRequestBaseVariant2? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recraft.ImageColor>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ProcessImageJSONRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ProcessImageRequestBase? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ProcessImageJSONRequestVariant2? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ProcessImageMultipartResponse? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ProcessImageResponse? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ProcessImageRequest? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ProcessImageRequestVariant2? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ReturnGradients? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.ShapeStacking? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.SmallShapeFilter? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.SvgCompression? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TextLayoutItem? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TransformImageJSONRequestVariant2? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TransformImageRequestVariant2? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TransformImageWithMaskJSONRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TransformImageWithMaskJSONRequestVariant2? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TransformImageWithMaskRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.TransformImageWithMaskRequestVariant2? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.User? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VariateImageJSONRequest? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VariateImageRequestBase? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VariateImageJSONRequestVariant2? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VariateImageRequest? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VariateImageRequestVariant2? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VectorizeImageJSONRequest? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VectorizeImageRequestBase? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VectorizeImageJSONRequestVariant2? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VectorizeImageRequest? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VectorizeImageRequestVariant2? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recraft.VectorizeImageRequestBaseVariant2? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type106 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recraft.TextLayoutItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recraft.Image>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recraft.BasicStyle>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recraft.Style>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recraft.ImageColor>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType11 { get; set; }
    }
}