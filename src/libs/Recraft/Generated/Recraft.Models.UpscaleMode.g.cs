
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpscaleMode
    {
        /// <summary>
        /// 
        /// </summary>
        Upscale16mp,
        /// <summary>
        /// 
        /// </summary>
        Upscale4mp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpscaleModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleMode value)
        {
            return value switch
            {
                UpscaleMode.Upscale16mp => "upscale16mp",
                UpscaleMode.Upscale4mp => "upscale4mp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleMode? ToEnum(string value)
        {
            return value switch
            {
                "upscale16mp" => UpscaleMode.Upscale16mp,
                "upscale4mp" => UpscaleMode.Upscale4mp,
                _ => null,
            };
        }
    }
}