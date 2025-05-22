#nullable enable

namespace Recraft
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Inpaint Image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.GenerateImageResponse> InpaintImageAsync(
            global::Recraft.TransformImageWithMaskRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Inpaint Image
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.GenerateImageResponse> InpaintImageAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}