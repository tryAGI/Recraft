
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
        CutOut,
        /// <summary>
        ///
        /// </summary>
        Hierarchical,
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
                ShapeStacking.CutOut => "cut_out",
                ShapeStacking.Hierarchical => "hierarchical",
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
                "cut_out" => ShapeStacking.CutOut,
                "hierarchical" => ShapeStacking.Hierarchical,
                _ => null,
            };
        }
    }
}