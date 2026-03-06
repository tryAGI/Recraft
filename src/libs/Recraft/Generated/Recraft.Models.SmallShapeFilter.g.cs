
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum SmallShapeFilter
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
    public static class SmallShapeFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmallShapeFilter value)
        {
            return value switch
            {
                SmallShapeFilter.On => "on",
                SmallShapeFilter.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmallShapeFilter? ToEnum(string value)
        {
            return value switch
            {
                "on" => SmallShapeFilter.On,
                "off" => SmallShapeFilter.Off,
                _ => null,
            };
        }
    }
}