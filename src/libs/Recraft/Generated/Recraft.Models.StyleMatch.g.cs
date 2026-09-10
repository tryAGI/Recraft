
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
        Flexible,
        /// <summary>
        ///
        /// </summary>
        Precise,
        /// <summary>
        ///
        /// </summary>
        Regular,
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
                StyleMatch.Flexible => "flexible",
                StyleMatch.Precise => "precise",
                StyleMatch.Regular => "regular",
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
                "flexible" => StyleMatch.Flexible,
                "precise" => StyleMatch.Precise,
                "regular" => StyleMatch.Regular,
                _ => null,
            };
        }
    }
}