using Innovision_Dashboard.Common.Interfaces;
using Innovision_Dashboard.Infrastructure.Game.Models.Response;
using Innovision_Dashboard.Infrastructure.Helpers;
using Innovision_Dashboard.Infrastructure.Interfaces;

namespace Innovision_Dashboard.Infrastructure.Game;

public class CoreApi : AbstractApiClient, ICoreApi
{
    private readonly string _clientId;

    public CoreApi(HttpClient? client, IAppConfig appConfig) : base(nameof(CoreApi), client)
    {
        _client.BaseAddress = new Uri(appConfig.CoreApiClient.BaseAddressUrl);
        _client.DefaultRequestHeaders.Add("Resource", appConfig.CoreApiClient.Resource);

        _clientId = appConfig.AppId;
    }

    public Task<ApiResponse<CompanyGameListResponse>> GetPlayerList(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}