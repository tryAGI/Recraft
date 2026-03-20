#nullable enable

namespace Recraft
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Exploration
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.GenerateImageResponse> ExploreAsync(

            global::Recraft.ExploreRequest request,
            global::Recraft.BillingType? billing = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exploration
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="blockNsfw"></param>
        /// <param name="controls"></param>
        /// <param name="expire"></param>
        /// <param name="imageFormat"></param>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="responseFormat"></param>
        /// <param name="size"></param>
        /// <param name="style"></param>
        /// <param name="styleId"></param>
        /// <param name="substyle"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.GenerateImageResponse> ExploreAsync(
            string prompt,
            global::Recraft.BillingType? billing = default,
            bool? blockNsfw = default,
            global::Recraft.UserControls? controls = default,
            bool? expire = default,
            global::Recraft.ImageFormat? imageFormat = default,
            global::Recraft.TransformModel? model = default,
            global::Recraft.ResponseFormat? responseFormat = default,
            global::Recraft.ImageSize? size = default,
            string? style = default,
            global::System.Guid? styleId = default,
            global::Recraft.ImageSubStyle? substyle = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}