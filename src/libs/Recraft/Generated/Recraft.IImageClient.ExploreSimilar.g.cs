#nullable enable

namespace Recraft
{
    public partial interface IImageClient
    {

        /// <summary>
        /// Continue exploration from a source image
        /// </summary>
        /// <param name="billing"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.GenerateImageResponse> ExploreSimilarAsync(

            global::Recraft.ExploreSimilarRequest request,
            global::Recraft.BillingType? billing = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Continue exploration from a source image
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="blockNsfw"></param>
        /// <param name="expire"></param>
        /// <param name="imageFormat"></param>
        /// <param name="responseFormat"></param>
        /// <param name="similarity"></param>
        /// <param name="sourceImageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.GenerateImageResponse> ExploreSimilarAsync(
            int similarity,
            global::System.Guid sourceImageId,
            global::Recraft.BillingType? billing = default,
            bool? blockNsfw = default,
            bool? expire = default,
            global::Recraft.ImageFormat? imageFormat = default,
            global::Recraft.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}