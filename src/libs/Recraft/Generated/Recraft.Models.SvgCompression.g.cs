
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
        SvgCompressionOn,
        /// <summary>
        /// 
        /// </summary>
        SvgCompressionOff,
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
                SvgCompression.SvgCompressionOn => "on",
                SvgCompression.SvgCompressionOff => "off",
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
                "on" => SvgCompression.SvgCompressionOn,
                "off" => SvgCompression.SvgCompressionOff,
                _ => null,
            };
        }
    }
}