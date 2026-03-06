
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
        Recraftv2Raster,
        /// <summary>
        /// 
        /// </summary>
        Recraftv2Vector,
        /// <summary>
        /// 
        /// </summary>
        Recraftv3,
        /// <summary>
        /// 
        /// </summary>
        Recraftv3Raster,
        /// <summary>
        /// 
        /// </summary>
        Recraftv3Vector,
        /// <summary>
        /// 
        /// </summary>
        Recraftv4,
        /// <summary>
        /// 
        /// </summary>
        Recraftv4Raster,
        /// <summary>
        /// 
        /// </summary>
        Recraftv4Vector,
        /// <summary>
        /// 
        /// </summary>
        Recraftv4Pro,
        /// <summary>
        /// 
        /// </summary>
        Recraftv4ProRaster,
        /// <summary>
        /// 
        /// </summary>
        Recraftv4ProVector,
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
        GptImage1p5Low,
        /// <summary>
        /// 
        /// </summary>
        GptImage1p5Medium,
        /// <summary>
        /// 
        /// </summary>
        GptImage1p5High,
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
        /// <summary>
        /// 
        /// </summary>
        QwenImage,
        /// <summary>
        /// 
        /// </summary>
        QwenImage2,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashImage,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedreamv4,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedreamv4p5,
        /// <summary>
        /// 
        /// </summary>
        NanoBananaPro,
        /// <summary>
        /// 
        /// </summary>
        NanoBananaPro4k,
        /// <summary>
        /// 
        /// </summary>
        NanoBanana2,
        /// <summary>
        /// 
        /// </summary>
        NanoBanana2With4k,
        /// <summary>
        /// 
        /// </summary>
        Flux2Dev,
        /// <summary>
        /// 
        /// </summary>
        Flux2Pro,
        /// <summary>
        /// 
        /// </summary>
        Flux2Flex,
        /// <summary>
        /// 
        /// </summary>
        Flux2Max,
        /// <summary>
        /// 
        /// </summary>
        ZImageTurbo,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedreamv5Lite,
        /// <summary>
        /// 
        /// </summary>
        QwenImage2Pro,
        /// <summary>
        /// 
        /// </summary>
        Flux1Schnell,
        /// <summary>
        /// 
        /// </summary>
        GrokImagineImage,
        /// <summary>
        /// 
        /// </summary>
        Veo3p1,
        /// <summary>
        /// 
        /// </summary>
        Veo3p1Fast,
        /// <summary>
        /// 
        /// </summary>
        Veo3,
        /// <summary>
        /// 
        /// </summary>
        Veo3Fast,
        /// <summary>
        /// 
        /// </summary>
        Veo2,
        /// <summary>
        /// 
        /// </summary>
        Sora2Pro,
        /// <summary>
        /// 
        /// </summary>
        Sora2,
        /// <summary>
        /// 
        /// </summary>
        Ray2,
        /// <summary>
        /// 
        /// </summary>
        Ray2Flash,
        /// <summary>
        /// 
        /// </summary>
        Kling2p6Pro,
        /// <summary>
        /// 
        /// </summary>
        Kling2p5Turbo,
        /// <summary>
        /// 
        /// </summary>
        Kling2p1Master,
        /// <summary>
        /// 
        /// </summary>
        Hailuo02Pro,
        /// <summary>
        /// 
        /// </summary>
        Hailuo02Standard,
        /// <summary>
        /// 
        /// </summary>
        Hailuo2p3Pro,
        /// <summary>
        /// 
        /// </summary>
        Hailuo2p3Standard,
        /// <summary>
        /// 
        /// </summary>
        Wan2p6,
        /// <summary>
        /// 
        /// </summary>
        Wan2p5Preview,
        /// <summary>
        /// 
        /// </summary>
        Wan2p2A14b,
        /// <summary>
        /// 
        /// </summary>
        BytedanceSeedance1p5,
        /// <summary>
        /// 
        /// </summary>
        PixverseV5p5,
        /// <summary>
        /// 
        /// </summary>
        GrokImagineVideo,
        /// <summary>
        /// 
        /// </summary>
        Kling3Pro,
        /// <summary>
        /// 
        /// </summary>
        Kling3Standard,
        /// <summary>
        /// 
        /// </summary>
        Kling3OmniPro,
        /// <summary>
        /// 
        /// </summary>
        Kling3OmniStandard,
        /// <summary>
        /// 
        /// </summary>
        RecraftSuperResolution,
        /// <summary>
        /// 
        /// </summary>
        RecraftGenerativeUpscale,
        /// <summary>
        /// 
        /// </summary>
        Topaz,
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
                TransformModel.Recraftv2Raster => "recraftv2_raster",
                TransformModel.Recraftv2Vector => "recraftv2_vector",
                TransformModel.Recraftv3 => "recraftv3",
                TransformModel.Recraftv3Raster => "recraftv3_raster",
                TransformModel.Recraftv3Vector => "recraftv3_vector",
                TransformModel.Recraftv4 => "recraftv4",
                TransformModel.Recraftv4Raster => "recraftv4_raster",
                TransformModel.Recraftv4Vector => "recraftv4_vector",
                TransformModel.Recraftv4Pro => "recraftv4_pro",
                TransformModel.Recraftv4ProRaster => "recraftv4_pro_raster",
                TransformModel.Recraftv4ProVector => "recraftv4_pro_vector",
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
                TransformModel.GptImage1p5Low => "gpt_image_1p5_low",
                TransformModel.GptImage1p5Medium => "gpt_image_1p5_medium",
                TransformModel.GptImage1p5High => "gpt_image_1p5_high",
                TransformModel.IdeogramV3Turbo => "ideogram_v3_turbo",
                TransformModel.IdeogramV3Default => "ideogram_v3_default",
                TransformModel.IdeogramV3Quality => "ideogram_v3_quality",
                TransformModel.QwenImage => "qwen_image",
                TransformModel.QwenImage2 => "qwen_image_2",
                TransformModel.Gemini25FlashImage => "gemini_25_flash_image",
                TransformModel.BytedanceSeedreamv4 => "bytedance-seedreamv4",
                TransformModel.BytedanceSeedreamv4p5 => "bytedance_seedreamv4p5",
                TransformModel.NanoBananaPro => "nano_banana_pro",
                TransformModel.NanoBananaPro4k => "nano_banana_pro_4k",
                TransformModel.NanoBanana2 => "nano_banana_2",
                TransformModel.NanoBanana2With4k => "nano_banana_2_with_4k",
                TransformModel.Flux2Dev => "flux2_dev",
                TransformModel.Flux2Pro => "flux2_pro",
                TransformModel.Flux2Flex => "flux2_flex",
                TransformModel.Flux2Max => "flux2_max",
                TransformModel.ZImageTurbo => "z_image_turbo",
                TransformModel.BytedanceSeedreamv5Lite => "bytedance_seedreamv5_lite",
                TransformModel.QwenImage2Pro => "qwen_image_2_pro",
                TransformModel.Flux1Schnell => "flux1_schnell",
                TransformModel.GrokImagineImage => "grok_imagine_image",
                TransformModel.Veo3p1 => "veo3p1",
                TransformModel.Veo3p1Fast => "veo3p1_fast",
                TransformModel.Veo3 => "veo3",
                TransformModel.Veo3Fast => "veo3_fast",
                TransformModel.Veo2 => "veo2",
                TransformModel.Sora2Pro => "sora2_pro",
                TransformModel.Sora2 => "sora2",
                TransformModel.Ray2 => "ray2",
                TransformModel.Ray2Flash => "ray2_flash",
                TransformModel.Kling2p6Pro => "kling2p6_pro",
                TransformModel.Kling2p5Turbo => "kling2p5_turbo",
                TransformModel.Kling2p1Master => "kling2p1_master",
                TransformModel.Hailuo02Pro => "hailuo02_pro",
                TransformModel.Hailuo02Standard => "hailuo02_standard",
                TransformModel.Hailuo2p3Pro => "hailuo2p3_pro",
                TransformModel.Hailuo2p3Standard => "hailuo2p3_standard",
                TransformModel.Wan2p6 => "wan2p6",
                TransformModel.Wan2p5Preview => "wan2p5_preview",
                TransformModel.Wan2p2A14b => "wan2p2_a14b",
                TransformModel.BytedanceSeedance1p5 => "bytedance_seedance1p5",
                TransformModel.PixverseV5p5 => "pixverse_v5p5",
                TransformModel.GrokImagineVideo => "grok_imagine_video",
                TransformModel.Kling3Pro => "kling3_pro",
                TransformModel.Kling3Standard => "kling3_standard",
                TransformModel.Kling3OmniPro => "kling3_omni_pro",
                TransformModel.Kling3OmniStandard => "kling3_omni_standard",
                TransformModel.RecraftSuperResolution => "recraft_super_resolution",
                TransformModel.RecraftGenerativeUpscale => "recraft_generative_upscale",
                TransformModel.Topaz => "topaz",
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
                "recraftv2_raster" => TransformModel.Recraftv2Raster,
                "recraftv2_vector" => TransformModel.Recraftv2Vector,
                "recraftv3" => TransformModel.Recraftv3,
                "recraftv3_raster" => TransformModel.Recraftv3Raster,
                "recraftv3_vector" => TransformModel.Recraftv3Vector,
                "recraftv4" => TransformModel.Recraftv4,
                "recraftv4_raster" => TransformModel.Recraftv4Raster,
                "recraftv4_vector" => TransformModel.Recraftv4Vector,
                "recraftv4_pro" => TransformModel.Recraftv4Pro,
                "recraftv4_pro_raster" => TransformModel.Recraftv4ProRaster,
                "recraftv4_pro_vector" => TransformModel.Recraftv4ProVector,
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
                "gpt_image_1p5_low" => TransformModel.GptImage1p5Low,
                "gpt_image_1p5_medium" => TransformModel.GptImage1p5Medium,
                "gpt_image_1p5_high" => TransformModel.GptImage1p5High,
                "ideogram_v3_turbo" => TransformModel.IdeogramV3Turbo,
                "ideogram_v3_default" => TransformModel.IdeogramV3Default,
                "ideogram_v3_quality" => TransformModel.IdeogramV3Quality,
                "qwen_image" => TransformModel.QwenImage,
                "qwen_image_2" => TransformModel.QwenImage2,
                "gemini_25_flash_image" => TransformModel.Gemini25FlashImage,
                "bytedance-seedreamv4" => TransformModel.BytedanceSeedreamv4,
                "bytedance_seedreamv4p5" => TransformModel.BytedanceSeedreamv4p5,
                "nano_banana_pro" => TransformModel.NanoBananaPro,
                "nano_banana_pro_4k" => TransformModel.NanoBananaPro4k,
                "nano_banana_2" => TransformModel.NanoBanana2,
                "nano_banana_2_with_4k" => TransformModel.NanoBanana2With4k,
                "flux2_dev" => TransformModel.Flux2Dev,
                "flux2_pro" => TransformModel.Flux2Pro,
                "flux2_flex" => TransformModel.Flux2Flex,
                "flux2_max" => TransformModel.Flux2Max,
                "z_image_turbo" => TransformModel.ZImageTurbo,
                "bytedance_seedreamv5_lite" => TransformModel.BytedanceSeedreamv5Lite,
                "qwen_image_2_pro" => TransformModel.QwenImage2Pro,
                "flux1_schnell" => TransformModel.Flux1Schnell,
                "grok_imagine_image" => TransformModel.GrokImagineImage,
                "veo3p1" => TransformModel.Veo3p1,
                "veo3p1_fast" => TransformModel.Veo3p1Fast,
                "veo3" => TransformModel.Veo3,
                "veo3_fast" => TransformModel.Veo3Fast,
                "veo2" => TransformModel.Veo2,
                "sora2_pro" => TransformModel.Sora2Pro,
                "sora2" => TransformModel.Sora2,
                "ray2" => TransformModel.Ray2,
                "ray2_flash" => TransformModel.Ray2Flash,
                "kling2p6_pro" => TransformModel.Kling2p6Pro,
                "kling2p5_turbo" => TransformModel.Kling2p5Turbo,
                "kling2p1_master" => TransformModel.Kling2p1Master,
                "hailuo02_pro" => TransformModel.Hailuo02Pro,
                "hailuo02_standard" => TransformModel.Hailuo02Standard,
                "hailuo2p3_pro" => TransformModel.Hailuo2p3Pro,
                "hailuo2p3_standard" => TransformModel.Hailuo2p3Standard,
                "wan2p6" => TransformModel.Wan2p6,
                "wan2p5_preview" => TransformModel.Wan2p5Preview,
                "wan2p2_a14b" => TransformModel.Wan2p2A14b,
                "bytedance_seedance1p5" => TransformModel.BytedanceSeedance1p5,
                "pixverse_v5p5" => TransformModel.PixverseV5p5,
                "grok_imagine_video" => TransformModel.GrokImagineVideo,
                "kling3_pro" => TransformModel.Kling3Pro,
                "kling3_standard" => TransformModel.Kling3Standard,
                "kling3_omni_pro" => TransformModel.Kling3OmniPro,
                "kling3_omni_standard" => TransformModel.Kling3OmniStandard,
                "recraft_super_resolution" => TransformModel.RecraftSuperResolution,
                "recraft_generative_upscale" => TransformModel.RecraftGenerativeUpscale,
                "topaz" => TransformModel.Topaz,
                _ => null,
            };
        }
    }
}