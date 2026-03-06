
#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public enum BillingType
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingType value)
        {
            return value switch
            {
                BillingType.Api => "api",
                BillingType.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingType? ToEnum(string value)
        {
            return value switch
            {
                "api" => BillingType.Api,
                "subscription" => BillingType.Subscription,
                _ => null,
            };
        }
    }
}