
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReturnGradients
    {
        /// <summary>
        /// 
        /// </summary>
        ReturnGradientsOff,
        /// <summary>
        /// 
        /// </summary>
        ReturnGradientsOn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnGradientsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnGradients value)
        {
            return value switch
            {
                ReturnGradients.ReturnGradientsOff => "off",
                ReturnGradients.ReturnGradientsOn => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnGradients? ToEnum(string value)
        {
            return value switch
            {
                "off" => ReturnGradients.ReturnGradientsOff,
                "on" => ReturnGradients.ReturnGradientsOn,
                _ => null,
            };
        }
    }
}