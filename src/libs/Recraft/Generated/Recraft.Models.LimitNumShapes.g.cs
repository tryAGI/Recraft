
#nullable enable

namespace Recraft
{
    /// <summary>
    ///
    /// </summary>
    public enum LimitNumShapes
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
    public static class LimitNumShapesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LimitNumShapes value)
        {
            return value switch
            {
                LimitNumShapes.Off => "off",
                LimitNumShapes.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LimitNumShapes? ToEnum(string value)
        {
            return value switch
            {
                "off" => LimitNumShapes.Off,
                "on" => LimitNumShapes.On,
                _ => null,
            };
        }
    }
}