#nullable enable

namespace Recraft
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Crisp Upscale
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> CrispUpscaleAsync(
            global::Recraft.ProcessImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Crisp Upscale
        /// </summary>
        /// <param name="expire"></param>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="imageFormat"></param>
        /// <param name="responseFormat"></param>
        /// <param name="upscale"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> CrispUpscaleAsync(
            byte[] image,
            string imagename,
            bool? expire = default,
            global::Recraft.ImageFormat? imageFormat = default,
            global::Recraft.ResponseFormat? responseFormat = default,
            global::Recraft.UpscaleMode? upscale = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}