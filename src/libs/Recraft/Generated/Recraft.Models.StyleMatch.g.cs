
#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public enum StyleMatch
    {
        /// <summary>
        ///
        /// </summary>
        StyleMatchFlexible,
        /// <summary>
        ///
        /// </summary>
        StyleMatchPrecise,
        /// <summary>
        ///
        /// </summary>
        StyleMatchRegular,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StyleMatchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StyleMatch value)
        {
            return value switch
            {
                StyleMatch.StyleMatchFlexible => "flexible",
                StyleMatch.StyleMatchPrecise => "precise",
                StyleMatch.StyleMatchRegular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StyleMatch? ToEnum(string value)
        {
            return value switch
            {
                "flexible" => StyleMatch.StyleMatchFlexible,
                "precise" => StyleMatch.StyleMatchPrecise,
                "regular" => StyleMatch.StyleMatchRegular,
                _ => null,
            };
        }
    }
}