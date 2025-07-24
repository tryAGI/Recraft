
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum TransformModel
    {
        /// <summary>
        /// 
        /// </summary>
        Refm1,
        /// <summary>
        /// 
        /// </summary>
        Recraft20b,
        /// <summary>
        /// 
        /// </summary>
        Recraftv2,
        /// <summary>
        /// 
        /// </summary>
        Recraftv3,
        /// <summary>
        /// 
        /// </summary>
        Flux1KontextPro,
        /// <summary>
        /// 
        /// </summary>
        Flux1KontextMax,
        /// <summary>
        /// 
        /// </summary>
        Flux11pro,
        /// <summary>
        /// 
        /// </summary>
        Flux1dev,
        /// <summary>
        /// 
        /// </summary>
        Imagen3,
        /// <summary>
        /// 
        /// </summary>
        Imagen4,
        /// <summary>
        /// 
        /// </summary>
        Imagen4Ultra,
        /// <summary>
        /// 
        /// </summary>
        HidreamI1Dev,
        /// <summary>
        /// 
        /// </summary>
        GptImage1Low,
        /// <summary>
        /// 
        /// </summary>
        GptImage1Medium,
        /// <summary>
        /// 
        /// </summary>
        GptImage1High,
        /// <summary>
        /// 
        /// </summary>
        IdeogramV3Turbo,
        /// <summary>
        /// 
        /// </summary>
        IdeogramV3Default,
        /// <summary>
        /// 
        /// </summary>
        IdeogramV3Quality,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransformModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransformModel value)
        {
            return value switch
            {
                TransformModel.Refm1 => "refm1",
                TransformModel.Recraft20b => "recraft20b",
                TransformModel.Recraftv2 => "recraftv2",
                TransformModel.Recraftv3 => "recraftv3",
                TransformModel.Flux1KontextPro => "flux1_kontext_pro",
                TransformModel.Flux1KontextMax => "flux1_kontext_max",
                TransformModel.Flux11pro => "flux1_1pro",
                TransformModel.Flux1dev => "flux1dev",
                TransformModel.Imagen3 => "imagen3",
                TransformModel.Imagen4 => "imagen4",
                TransformModel.Imagen4Ultra => "imagen4_ultra",
                TransformModel.HidreamI1Dev => "hidream_i1_dev",
                TransformModel.GptImage1Low => "gpt_image_1_low",
                TransformModel.GptImage1Medium => "gpt_image_1_medium",
                TransformModel.GptImage1High => "gpt_image_1_high",
                TransformModel.IdeogramV3Turbo => "ideogram_v3_turbo",
                TransformModel.IdeogramV3Default => "ideogram_v3_default",
                TransformModel.IdeogramV3Quality => "ideogram_v3_quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransformModel? ToEnum(string value)
        {
            return value switch
            {
                "refm1" => TransformModel.Refm1,
                "recraft20b" => TransformModel.Recraft20b,
                "recraftv2" => TransformModel.Recraftv2,
                "recraftv3" => TransformModel.Recraftv3,
                "flux1_kontext_pro" => TransformModel.Flux1KontextPro,
                "flux1_kontext_max" => TransformModel.Flux1KontextMax,
                "flux1_1pro" => TransformModel.Flux11pro,
                "flux1dev" => TransformModel.Flux1dev,
                "imagen3" => TransformModel.Imagen3,
                "imagen4" => TransformModel.Imagen4,
                "imagen4_ultra" => TransformModel.Imagen4Ultra,
                "hidream_i1_dev" => TransformModel.HidreamI1Dev,
                "gpt_image_1_low" => TransformModel.GptImage1Low,
                "gpt_image_1_medium" => TransformModel.GptImage1Medium,
                "gpt_image_1_high" => TransformModel.GptImage1High,
                "ideogram_v3_turbo" => TransformModel.IdeogramV3Turbo,
                "ideogram_v3_default" => TransformModel.IdeogramV3Default,
                "ideogram_v3_quality" => TransformModel.IdeogramV3Quality,
                _ => null,
            };
        }
    }
}