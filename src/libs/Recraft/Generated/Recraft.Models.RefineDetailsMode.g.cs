
#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public enum RefineDetailsMode
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
    public static class RefineDetailsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefineDetailsMode value)
        {
            return value switch
            {
                RefineDetailsMode.Moderate => "moderate",
                RefineDetailsMode.Subtle => "subtle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefineDetailsMode? ToEnum(string value)
        {
            return value switch
            {
                "moderate" => RefineDetailsMode.Moderate,
                "subtle" => RefineDetailsMode.Subtle,
                _ => null,
            };
        }
    }
}