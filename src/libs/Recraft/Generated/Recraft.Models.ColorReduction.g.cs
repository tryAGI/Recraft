
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColorReduction
    {
        /// <summary>
        /// 
        /// </summary>
        On,
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColorReductionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColorReduction value)
        {
            return value switch
            {
                ColorReduction.On => "on",
                ColorReduction.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColorReduction? ToEnum(string value)
        {
            return value switch
            {
                "on" => ColorReduction.On,
                "off" => ColorReduction.Off,
                _ => null,
            };
        }
    }
}