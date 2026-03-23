
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
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
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
                ColorReduction.Off => "off",
                ColorReduction.On => "on",
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
                "off" => ColorReduction.Off,
                "on" => ColorReduction.On,
                _ => null,
            };
        }
    }
}