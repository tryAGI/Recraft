#nullable enable

namespace Recraft
{
    public partial interface IRecraftClient
    {
        /// <summary>
        /// Get System Status
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recraft.SystemStatus> GetSystemStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}