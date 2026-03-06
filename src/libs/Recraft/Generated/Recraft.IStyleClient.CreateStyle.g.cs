#nullable enable

namespace Recraft
{
    public partial interface IStyleClient
    {
        /// <summary>
        /// Create Style
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.CreateStyleResponse> CreateStyleAsync(

            global::Recraft.CreateStyleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Style
        /// </summary>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.CreateStyleResponse> CreateStyleAsync(
            global::System.Collections.Generic.IList<byte[]> images,
            global::Recraft.ImageStyle style,
            global::System.Collections.Generic.IList<double>? imageWeights = default,
            global::Recraft.MixPolicy? mixPolicy = default,
            global::Recraft.TransformModel? model = default,
            global::Recraft.PaletteSuggest? palette = default,
            bool? @private = default,
            string? prompt = default,
            global::System.Collections.Generic.IList<double>? sourceStyleWeights = default,
            global::System.Collections.Generic.IList<global::System.Guid>? sourceStyles = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}