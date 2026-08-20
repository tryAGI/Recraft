
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum StyleMode
    {
        /// <summary>
        /// 
        /// </summary>
        StyleModeFlexible,
        /// <summary>
        /// 
        /// </summary>
        StyleModePrecise,
        /// <summary>
        /// 
        /// </summary>
        StyleModeRegular,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StyleModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StyleMode value)
        {
            return value switch
            {
                StyleMode.StyleModeFlexible => "flexible",
                StyleMode.StyleModePrecise => "precise",
                StyleMode.StyleModeRegular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StyleMode? ToEnum(string value)
        {
            return value switch
            {
                "flexible" => StyleMode.StyleModeFlexible,
                "precise" => StyleMode.StyleModePrecise,
                "regular" => StyleMode.StyleModeRegular,
                _ => null,
            };
        }
    }
}