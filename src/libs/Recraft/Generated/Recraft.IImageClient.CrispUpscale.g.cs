#nullable enable

namespace Recraft
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Crisp Upscale
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> CrispUpscaleAsync(

            global::Recraft.ProcessImageRequest request,
            global::Recraft.BillingType? billing = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Crisp Upscale
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.AutoSDKHttpResponse<global::Recraft.ProcessImageResponse>> CrispUpscaleAsResponseAsync(

            global::Recraft.ProcessImageRequest request,
            global::Recraft.BillingType? billing = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Crisp Upscale
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="expire"></param>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="imageFormat"></param>
        /// <param name="responseFormat"></param>
        /// <param name="upscale"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> CrispUpscaleAsync(
            byte[] image,
            string imagename,
            global::Recraft.BillingType? billing = default,
            bool? expire = default,
            global::Recraft.ImageFormat? imageFormat = default,
            global::Recraft.ResponseFormat? responseFormat = default,
            global::Recraft.UpscaleMode? upscale = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Crisp Upscale
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="expire"></param>
        /// <param name="image">
        /// The stream to send as the multipart 'image' file part.
        /// </param>
        /// <param name="imagename"></param>
        /// <param name="imageFormat"></param>
        /// <param name="responseFormat"></param>
        /// <param name="upscale"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.ProcessImageResponse> CrispUpscaleAsync(
            global::System.IO.Stream image,
            string imagename,
            global::Recraft.BillingType? billing = default,
            bool? expire = default,
            global::Recraft.ImageFormat? imageFormat = default,
            global::Recraft.ResponseFormat? responseFormat = default,
            global::Recraft.UpscaleMode? upscale = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Crisp Upscale
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="expire"></param>
        /// <param name="image">
        /// The stream to send as the multipart 'image' file part.
        /// </param>
        /// <param name="imagename"></param>
        /// <param name="imageFormat"></param>
        /// <param name="responseFormat"></param>
        /// <param name="upscale"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.AutoSDKHttpResponse<global::Recraft.ProcessImageResponse>> CrispUpscaleAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::Recraft.BillingType? billing = default,
            bool? expire = default,
            global::Recraft.ImageFormat? imageFormat = default,
            global::Recraft.ResponseFormat? responseFormat = default,
            global::Recraft.UpscaleMode? upscale = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}