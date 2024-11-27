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
            global::Recraft.InpaintImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Inpaint Image
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="mask"></param>
        /// <param name="maskname"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="prompt"></param>
        /// <param name="randomSeed"></param>
        /// <param name="responseFormat"></param>
        /// <param name="style"></param>
        /// <param name="styleId"></param>
        /// <param name="substyle"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.GenerateImageResponse> InpaintImageAsync(
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            string prompt,
            global::Recraft.UserControls? controls = default,
            global::Recraft.TransformModel? model = default,
            int? n = default,
            int? randomSeed = default,
            global::Recraft.ResponseFormat? responseFormat = default,
            global::Recraft.ImageStyle? style = default,
            global::System.Guid? styleId = default,
            global::Recraft.ImageSubStyle? substyle = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}