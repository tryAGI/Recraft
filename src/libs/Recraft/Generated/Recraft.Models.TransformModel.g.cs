
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
        Recraftv41,
        /// <summary>
        ///
        /// </summary>
        Recraftv41Pro,
        /// <summary>
        ///
        /// </summary>
        Recraftv41ProRaster,
        /// <summary>
        ///
        /// </summary>
        Recraftv41ProVector,
        /// <summary>
        ///
        /// </summary>
        Recraftv41Raster,
        /// <summary>
        ///
        /// </summary>
        Recraftv41Utility,
        /// <summary>
        ///
        /// </summary>
        Recraftv41UtilityPro,
        /// <summary>
        ///
        /// </summary>
        Recraftv41UtilityProRaster,
        /// <summary>
        ///
        /// </summary>
        Recraftv41UtilityProVector,
        /// <summary>
        ///
        /// </summary>
        Recraftv41UtilityRaster,
        /// <summary>
        ///
        /// </summary>
        Recraftv41UtilityVector,
        /// <summary>
        ///
        /// </summary>
        Recraftv41Vector,
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
        Recraftv4Raster,
        /// <summary>
        ///
        /// </summary>
        Recraftv4Styles,
        /// <summary>
        ///
        /// </summary>
        Recraftv4StylesPro,
        /// <summary>
        ///
        /// </summary>
        Recraftv4StylesProRaster,
        /// <summary>
        ///
        /// </summary>
        Recraftv4StylesProVector,
        /// <summary>
        ///
        /// </summary>
        Recraftv4StylesRaster,
        /// <summary>
        ///
        /// </summary>
        Recraftv4StylesVector,
        /// <summary>
        ///
        /// </summary>
        Recraftv4Vector,
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
                TransformModel.Recraftv2 => "recraftv2",
                TransformModel.Recraftv2Raster => "recraftv2_raster",
                TransformModel.Recraftv2Vector => "recraftv2_vector",
                TransformModel.Recraftv3 => "recraftv3",
                TransformModel.Recraftv3Raster => "recraftv3_raster",
                TransformModel.Recraftv3Vector => "recraftv3_vector",
                TransformModel.Recraftv4 => "recraftv4",
                TransformModel.Recraftv41 => "recraftv4_1",
                TransformModel.Recraftv41Pro => "recraftv4_1_pro",
                TransformModel.Recraftv41ProRaster => "recraftv4_1_pro_raster",
                TransformModel.Recraftv41ProVector => "recraftv4_1_pro_vector",
                TransformModel.Recraftv41Raster => "recraftv4_1_raster",
                TransformModel.Recraftv41Utility => "recraftv4_1_utility",
                TransformModel.Recraftv41UtilityPro => "recraftv4_1_utility_pro",
                TransformModel.Recraftv41UtilityProRaster => "recraftv4_1_utility_pro_raster",
                TransformModel.Recraftv41UtilityProVector => "recraftv4_1_utility_pro_vector",
                TransformModel.Recraftv41UtilityRaster => "recraftv4_1_utility_raster",
                TransformModel.Recraftv41UtilityVector => "recraftv4_1_utility_vector",
                TransformModel.Recraftv41Vector => "recraftv4_1_vector",
                TransformModel.Recraftv4Pro => "recraftv4_pro",
                TransformModel.Recraftv4ProRaster => "recraftv4_pro_raster",
                TransformModel.Recraftv4ProVector => "recraftv4_pro_vector",
                TransformModel.Recraftv4Raster => "recraftv4_raster",
                TransformModel.Recraftv4Styles => "recraftv4_styles",
                TransformModel.Recraftv4StylesPro => "recraftv4_styles_pro",
                TransformModel.Recraftv4StylesProRaster => "recraftv4_styles_pro_raster",
                TransformModel.Recraftv4StylesProVector => "recraftv4_styles_pro_vector",
                TransformModel.Recraftv4StylesRaster => "recraftv4_styles_raster",
                TransformModel.Recraftv4StylesVector => "recraftv4_styles_vector",
                TransformModel.Recraftv4Vector => "recraftv4_vector",
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
                "recraftv2" => TransformModel.Recraftv2,
                "recraftv2_raster" => TransformModel.Recraftv2Raster,
                "recraftv2_vector" => TransformModel.Recraftv2Vector,
                "recraftv3" => TransformModel.Recraftv3,
                "recraftv3_raster" => TransformModel.Recraftv3Raster,
                "recraftv3_vector" => TransformModel.Recraftv3Vector,
                "recraftv4" => TransformModel.Recraftv4,
                "recraftv4_1" => TransformModel.Recraftv41,
                "recraftv4_1_pro" => TransformModel.Recraftv41Pro,
                "recraftv4_1_pro_raster" => TransformModel.Recraftv41ProRaster,
                "recraftv4_1_pro_vector" => TransformModel.Recraftv41ProVector,
                "recraftv4_1_raster" => TransformModel.Recraftv41Raster,
                "recraftv4_1_utility" => TransformModel.Recraftv41Utility,
                "recraftv4_1_utility_pro" => TransformModel.Recraftv41UtilityPro,
                "recraftv4_1_utility_pro_raster" => TransformModel.Recraftv41UtilityProRaster,
                "recraftv4_1_utility_pro_vector" => TransformModel.Recraftv41UtilityProVector,
                "recraftv4_1_utility_raster" => TransformModel.Recraftv41UtilityRaster,
                "recraftv4_1_utility_vector" => TransformModel.Recraftv41UtilityVector,
                "recraftv4_1_vector" => TransformModel.Recraftv41Vector,
                "recraftv4_pro" => TransformModel.Recraftv4Pro,
                "recraftv4_pro_raster" => TransformModel.Recraftv4ProRaster,
                "recraftv4_pro_vector" => TransformModel.Recraftv4ProVector,
                "recraftv4_raster" => TransformModel.Recraftv4Raster,
                "recraftv4_styles" => TransformModel.Recraftv4Styles,
                "recraftv4_styles_pro" => TransformModel.Recraftv4StylesPro,
                "recraftv4_styles_pro_raster" => TransformModel.Recraftv4StylesProRaster,
                "recraftv4_styles_pro_vector" => TransformModel.Recraftv4StylesProVector,
                "recraftv4_styles_raster" => TransformModel.Recraftv4StylesRaster,
                "recraftv4_styles_vector" => TransformModel.Recraftv4StylesVector,
                "recraftv4_vector" => TransformModel.Recraftv4Vector,
                _ => null,
            };
        }
    }
}