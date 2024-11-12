#nullable enable

namespace Recraft
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get current user info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.User> GetCurrentUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}