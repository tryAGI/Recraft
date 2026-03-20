#nullable enable

namespace Recraft
{
    public partial interface IStyleClient
    {
        /// <summary>
        /// List Basic Styles
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.ListBasicStylesResponse> ListBasicStylesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}