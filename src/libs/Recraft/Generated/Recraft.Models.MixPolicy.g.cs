
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum MixPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        MaxWeight,
        /// <summary>
        /// 
        /// </summary>
        PaletteMatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MixPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MixPolicy value)
        {
            return value switch
            {
                MixPolicy.MaxWeight => "MaxWeight",
                MixPolicy.PaletteMatch => "PaletteMatch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MixPolicy? ToEnum(string value)
        {
            return value switch
            {
                "MaxWeight" => MixPolicy.MaxWeight,
                "PaletteMatch" => MixPolicy.PaletteMatch,
                _ => null,
            };
        }
    }
}