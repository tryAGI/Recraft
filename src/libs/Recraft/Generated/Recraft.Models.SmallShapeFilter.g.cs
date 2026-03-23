
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
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
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
                SmallShapeFilter.Off => "off",
                SmallShapeFilter.On => "on",
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
                "off" => SmallShapeFilter.Off,
                "on" => SmallShapeFilter.On,
                _ => null,
            };
        }
    }
}