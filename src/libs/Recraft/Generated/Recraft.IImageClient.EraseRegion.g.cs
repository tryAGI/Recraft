#nullable enable

namespace Recraft
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Erase Region
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> EraseRegionAsync(
            global::Recraft.EraseRegionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Erase Region
        /// </summary>
        /// <param name="expire"></param>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="imageFormat"></param>
        /// <param name="mask"></param>
        /// <param name="maskname"></param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> EraseRegionAsync(
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            bool? expire = default,
            global::Recraft.ImageFormat? imageFormat = default,
            global::Recraft.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}