
#nullable enable

namespace Recraft
{
    /// <summary>
    /// Default Value: moderate
    /// </summary>
    public enum EnhanceMode
    {
        /// <summary>
        ///
        /// </summary>
        Moderate,
        /// <summary>
        ///
        /// </summary>
        Subtle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnhanceModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnhanceMode value)
        {
            return value switch
            {
                EnhanceMode.Moderate => "moderate",
                EnhanceMode.Subtle => "subtle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnhanceMode? ToEnum(string value)
        {
            return value switch
            {
                "moderate" => EnhanceMode.Moderate,
                "subtle" => EnhanceMode.Subtle,
                _ => null,
            };
        }
    }
}