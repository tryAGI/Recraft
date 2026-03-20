#nullable enable

namespace Recraft
{
    public partial interface IStyleClient
    {
        /// <summary>
        /// Get Style
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.Style> GetStyleAsync(
            global::System.Guid styleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}