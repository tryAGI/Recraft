
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        DigitalIllustration,
        /// <summary>
        /// 
        /// </summary>
        Icon,
        /// <summary>
        /// 
        /// </summary>
        RealisticImage,
        /// <summary>
        /// 
        /// </summary>
        VectorIllustration,
        /// <summary>
        /// 
        /// </summary>
        LogoRaster,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageStyle value)
        {
            return value switch
            {
                ImageStyle.Any => "any",
                ImageStyle.DigitalIllustration => "digital_illustration",
                ImageStyle.Icon => "icon",
                ImageStyle.RealisticImage => "realistic_image",
                ImageStyle.VectorIllustration => "vector_illustration",
                ImageStyle.LogoRaster => "logo_raster",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageStyle? ToEnum(string value)
        {
            return value switch
            {
                "any" => ImageStyle.Any,
                "digital_illustration" => ImageStyle.DigitalIllustration,
                "icon" => ImageStyle.Icon,
                "realistic_image" => ImageStyle.RealisticImage,
                "vector_illustration" => ImageStyle.VectorIllustration,
                "logo_raster" => ImageStyle.LogoRaster,
                _ => null,
            };
        }
    }
}