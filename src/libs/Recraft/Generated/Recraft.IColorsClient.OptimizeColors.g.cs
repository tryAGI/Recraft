#nullable enable

namespace Recraft
{
    public partial interface IColorsClient
    {

        /// <summary>
        /// Optimize colors
        /// </summary>
        /// <param name="billing"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.OptimizeColorsResponse> OptimizeColorsAsync(

            global::Recraft.OptimizeColorsRequest request,
            global::Recraft.BillingType? billing = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Optimize colors
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="colors"></param>
        /// <param name="numColorsLimit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.OptimizeColorsResponse> OptimizeColorsAsync(
            global::System.Collections.Generic.IList<global::Recraft.ColorHexAndWeight> colors,
            int numColorsLimit,
            global::Recraft.BillingType? billing = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}