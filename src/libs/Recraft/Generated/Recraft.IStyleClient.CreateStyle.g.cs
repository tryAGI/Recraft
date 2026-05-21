#nullable enable

namespace Recraft
{
    public partial interface IStyleClient
    {
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.CreateStyleResponse> CreateStyleAsync(

            global::Recraft.CreateStyleRequest request,
            global::Recraft.BillingType? billing = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.AutoSDKHttpResponse<global::Recraft.CreateStyleResponse>> CreateStyleAsResponseAsync(

            global::Recraft.CreateStyleRequest request,
            global::Recraft.BillingType? billing = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="imageWeights"></param>
        /// <param name="images"></param>
        /// <param name="mixPolicy"></param>
        /// <param name="model"></param>
        /// <param name="palette"></param>
        /// <param name="private"></param>
        /// <param name="prompt"></param>
        /// <param name="sourceStyleWeights"></param>
        /// <param name="sourceStyles"></param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.CreateStyleResponse> CreateStyleAsync(
            global::System.Collections.Generic.IList<byte[]> images,
            global::Recraft.ImageStyle style,
            global::Recraft.BillingType? billing = default,
            global::System.Collections.Generic.IList<double>? imageWeights = default,
            global::Recraft.MixPolicy? mixPolicy = default,
            global::Recraft.TransformModel? model = default,
            global::Recraft.PaletteSuggest? palette = default,
            bool? @private = default,
            string? prompt = default,
            global::System.Collections.Generic.IList<double>? sourceStyleWeights = default,
            global::System.Collections.Generic.IList<global::System.Guid>? sourceStyles = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="imageWeights"></param>
        /// <param name="images">
        /// The streams to send as multipart 'images' file parts.
        /// </param>
        /// <param name="imagesFileNames">
        /// Optional file names to use for the multipart 'images' file parts.
        /// </param>
        /// <param name="mixPolicy"></param>
        /// <param name="model"></param>
        /// <param name="palette"></param>
        /// <param name="private"></param>
        /// <param name="prompt"></param>
        /// <param name="sourceStyleWeights"></param>
        /// <param name="sourceStyles"></param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.CreateStyleResponse> CreateStyleAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> images,
            global::Recraft.ImageStyle style,
            global::Recraft.BillingType? billing = default,
            global::System.Collections.Generic.IList<double>? imageWeights = default,
            global::System.Collections.Generic.IReadOnlyList<string>? imagesFileNames = default,
            global::Recraft.MixPolicy? mixPolicy = default,
            global::Recraft.TransformModel? model = default,
            global::Recraft.PaletteSuggest? palette = default,
            bool? @private = default,
            string? prompt = default,
            global::System.Collections.Generic.IList<double>? sourceStyleWeights = default,
            global::System.Collections.Generic.IList<global::System.Guid>? sourceStyles = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="billing"></param>
        /// <param name="imageWeights"></param>
        /// <param name="images">
        /// The streams to send as multipart 'images' file parts.
        /// </param>
        /// <param name="imagesFileNames">
        /// Optional file names to use for the multipart 'images' file parts.
        /// </param>
        /// <param name="mixPolicy"></param>
        /// <param name="model"></param>
        /// <param name="palette"></param>
        /// <param name="private"></param>
        /// <param name="prompt"></param>
        /// <param name="sourceStyleWeights"></param>
        /// <param name="sourceStyles"></param>
        /// <param name="style"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.AutoSDKHttpResponse<global::Recraft.CreateStyleResponse>> CreateStyleAsResponseAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> images,
            global::Recraft.ImageStyle style,
            global::Recraft.BillingType? billing = default,
            global::System.Collections.Generic.IList<double>? imageWeights = default,
            global::System.Collections.Generic.IReadOnlyList<string>? imagesFileNames = default,
            global::Recraft.MixPolicy? mixPolicy = default,
            global::Recraft.TransformModel? model = default,
            global::Recraft.PaletteSuggest? palette = default,
            bool? @private = default,
            string? prompt = default,
            global::System.Collections.Generic.IList<double>? sourceStyleWeights = default,
            global::System.Collections.Generic.IList<global::System.Guid>? sourceStyles = default,
            global::Recraft.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}