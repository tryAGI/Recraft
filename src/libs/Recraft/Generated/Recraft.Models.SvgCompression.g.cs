
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum SvgCompression
    {
        /// <summary>
        /// 
        /// </summary>
        SvgCompressionOff,
        /// <summary>
        /// 
        /// </summary>
        SvgCompressionOn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgCompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgCompression value)
        {
            return value switch
            {
                SvgCompression.SvgCompressionOff => "off",
                SvgCompression.SvgCompressionOn => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgCompression? ToEnum(string value)
        {
            return value switch
            {
                "off" => SvgCompression.SvgCompressionOff,
                "on" => SvgCompression.SvgCompressionOn,
                _ => null,
            };
        }
    }
}