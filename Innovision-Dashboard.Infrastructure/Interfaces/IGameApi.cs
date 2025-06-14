using Innovision_Dashboard.Common.Interfaces;
using Innovision_Dashboard.Infrastructure.Game.Models.Response;

namespace Innovision_Dashboard.Infrastructure.Interfaces;

public interface IGameApi
{
    #region CompanyGame
        Task<ApiResponse<CompanyGameListResponse>> GetCompanyGameListAsync(string companyId, CancellationToken cancellationToken = default);
    #endregion
}