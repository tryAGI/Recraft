
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum ShapeStacking
    {
        /// <summary>
        /// 
        /// </summary>
        ShapeStackingCutOut,
        /// <summary>
        /// 
        /// </summary>
        ShapeStackingHierarchical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShapeStackingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShapeStacking value)
        {
            return value switch
            {
                ShapeStacking.ShapeStackingCutOut => "cut_out",
                ShapeStacking.ShapeStackingHierarchical => "hierarchical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShapeStacking? ToEnum(string value)
        {
            return value switch
            {
                "cut_out" => ShapeStacking.ShapeStackingCutOut,
                "hierarchical" => ShapeStacking.ShapeStackingHierarchical,
                _ => null,
            };
        }
    }
}