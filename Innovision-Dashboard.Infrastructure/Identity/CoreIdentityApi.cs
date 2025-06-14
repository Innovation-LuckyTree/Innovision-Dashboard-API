using Innovision_Dashboard.Common.Interfaces;
using Innovision_Dashboard.Infrastructure.Helpers;
using Innovision_Dashboard.Infrastructure.Identity.Models.Requests;
using Innovision_Dashboard.Infrastructure.Identity.Models.Responses;
using Innovision_Dashboard.Infrastructure.Interfaces;
using System.Net.Http.Json;

namespace HappyPlay.Infrastructure.CoreIdentity;

public class CoreIdentityApi : AbstractApiClient, ICoreIdentityApi
{
    private readonly string _clientId;

    public CoreIdentityApi(HttpClient? client, IAppConfig appConfig) : base(nameof(CoreIdentityApi), client)
    {
        _client.BaseAddress = new Uri(appConfig.CoreIdentityApiClient.BaseAddressUrl);
        _client.DefaultRequestHeaders.Add("Resource", appConfig.CoreIdentityApiClient.Resource);

        _clientId = appConfig.AppId;
    }

    public async Task<ApiResponse<LoginUserResponse>> LoginUser(string userName, string password, string ipAddress, CancellationToken cancellationToken)
    {
        var loginRequest = new LoginUserRequest
        {
            UserName = userName,
            Password = password,
            IpAddress = ipAddress
        };

        var response = await _client.PostAsJsonAsync("api/account/auth", loginRequest, cancellationToken);
        var content = await response.Content.ReadFromJsonAsync<ApiResponse<LoginUserResponse>>();

        return content!;
    }

    public async Task<object> GenerateRefreshToken(RefreshTokenRequest request, CancellationToken cancellationToken)
    {
        var response = await _client.PostAsJsonAsync("api/auth/token/refresh", request, cancellationToken);
        var content = await response.Content.ReadFromJsonAsync<object>();

        return content!;
    }

    public async Task<object> UnLockedUser(Guid UserAccountId, CancellationToken cancellationToken)
    {
        var response = await _client.PostAsJsonAsync("api/users/unlock", new { AccountId = UserAccountId }, cancellationToken);
        var content = await response.Content.ReadFromJsonAsync<object>();

        return content!;
    }

}