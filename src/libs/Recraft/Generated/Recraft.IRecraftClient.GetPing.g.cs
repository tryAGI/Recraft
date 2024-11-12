#nullable enable

namespace Recraft
{
    public partial interface IRecraftClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task GetPingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}