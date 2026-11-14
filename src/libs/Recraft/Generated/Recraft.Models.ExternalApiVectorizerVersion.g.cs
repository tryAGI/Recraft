
#nullable enable

namespace Recraft
{
    /// <summary>
    /// Vectorizer version. Defaults to v1.
    /// </summary>
    public enum ExternalApiVectorizerVersion
    {
        /// <summary>
        ///
        /// </summary>
        V1,
        /// <summary>
        ///
        /// </summary>
        V1Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalApiVectorizerVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalApiVectorizerVersion value)
        {
            return value switch
            {
                ExternalApiVectorizerVersion.V1 => "v1",
                ExternalApiVectorizerVersion.V1Pro => "v1_pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalApiVectorizerVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => ExternalApiVectorizerVersion.V1,
                "v1_pro" => ExternalApiVectorizerVersion.V1Pro,
                _ => null,
            };
        }
    }
}