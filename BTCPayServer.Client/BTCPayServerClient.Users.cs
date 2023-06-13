#nullable enable
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BTCPayServer.Client.Models;

namespace BTCPayServer.Client
{
    public partial class BTCPayServerClient
    {
        public virtual async Task<ApplicationUserData> GetCurrentUser(CancellationToken token = default)
        {
            var response = await _httpClient.SendAsync(CreateHttpRequest("api/v1/users/me"), token);
            return await HandleResponse<ApplicationUserData>(response);
        }

        public virtual async Task<ApplicationUserData> CreateUser(CreateApplicationUserRequest request,
            CancellationToken token = default)
        {
            var response = await _httpClient.SendAsync(CreateHttpRequest("api/v1/users", null, request, HttpMethod.Post), token);
            return await HandleResponse<ApplicationUserData>(response);
        }

        public virtual async Task DeleteUser(string userId, CancellationToken token = default)
        {
            var response = await _httpClient.SendAsync(CreateHttpRequest($"api/v1/users/{userId}", null, HttpMethod.Delete), token);
            await HandleResponse(response);
        }

        public virtual async Task DeleteCurrentUser(CancellationToken token = default)
        {
            await DeleteUser("me", token);
        }
    }
}
