using Innovision_Dashboard.Common.Interfaces;
using Innovision_Dashboard.Infrastructure.Game.Models.Response;

namespace Innovision_Dashboard.Infrastructure.Interfaces;

public interface ICoreApi
{
    #region Accounts
        Task<ApiResponse<CompanyGameListResponse>> GetPlayerList(CancellationToken cancellationToken = default);
    #endregion
}