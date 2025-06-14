using Innovision_Dashboard.Common.Interfaces;
using Innovision_Dashboard.Infrastructure.Game.Models.Response;
using Innovision_Dashboard.Infrastructure.Helpers;
using Innovision_Dashboard.Infrastructure.Interfaces;

namespace Innovision_Dashboard.Infrastructure.Game;

public class GameApi : AbstractApiClient, IGameApi
{
    private readonly string _clientId;

    public GameApi(HttpClient? client, IAppConfig appConfig) : base(nameof(GameApi), client)
    {
        _client.BaseAddress = new Uri(appConfig.GameApiClient.BaseAddressUrl);
        _client.DefaultRequestHeaders.Add("Resource", appConfig.GameApiClient.Resource);

        _clientId = appConfig.AppId;
    }

    public Task<ApiResponse<CompanyGameListResponse>> GetCompanyGameListAsync(string companyId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}