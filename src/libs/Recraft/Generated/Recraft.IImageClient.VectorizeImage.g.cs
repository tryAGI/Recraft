#nullable enable

namespace Recraft
{
    public partial interface IImageClient
    {

        /// <summary>
        /// Vectorize image
        /// </summary>
        /// <param name="billing"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> VectorizeImageAsync(

            global::Recraft.VectorizeImageRequest request,
            global::Recraft.BillingType? billing = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Vectorize image
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> VectorizeImageAsync(
            global::Recraft.BillingType? billing = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}