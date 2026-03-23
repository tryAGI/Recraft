
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageFormat value)
        {
            return value switch
            {
                ImageFormat.Png => "png",
                ImageFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageFormat? ToEnum(string value)
        {
            return value switch
            {
                "png" => ImageFormat.Png,
                "webp" => ImageFormat.Webp,
                _ => null,
            };
        }
    }
}