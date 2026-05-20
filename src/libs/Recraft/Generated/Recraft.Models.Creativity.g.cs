
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum Creativity
    {
        /// <summary>
        /// 
        /// </summary>
        Eccentric,
        /// <summary>
        /// 
        /// </summary>
        Simple,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreativityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Creativity value)
        {
            return value switch
            {
                Creativity.Eccentric => "eccentric",
                Creativity.Simple => "simple",
                Creativity.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Creativity? ToEnum(string value)
        {
            return value switch
            {
                "eccentric" => Creativity.Eccentric,
                "simple" => Creativity.Simple,
                "standard" => Creativity.Standard,
                _ => null,
            };
        }
    }
}