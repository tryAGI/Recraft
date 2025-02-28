
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
        Webp,
        /// <summary>
        /// 
        /// </summary>
        Png,
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
                ImageFormat.Webp => "webp",
                ImageFormat.Png => "png",
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
                "webp" => ImageFormat.Webp,
                "png" => ImageFormat.Png,
                _ => null,
            };
        }
    }
}