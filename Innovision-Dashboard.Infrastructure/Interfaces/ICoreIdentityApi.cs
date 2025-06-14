using Innovision_Dashboard.Common.Interfaces;
using Innovision_Dashboard.Infrastructure.Identity.Models.Requests;
using Innovision_Dashboard.Infrastructure.Identity.Models.Responses;

namespace Innovision_Dashboard.Infrastructure.Interfaces;

public interface ICoreIdentityApi
{
    Task<ApiResponse<LoginUserResponse>> LoginUser(string userName, string password, string ipAddress, CancellationToken cancellationToken);
    Task<object> GenerateRefreshToken(RefreshTokenRequest request, CancellationToken cancellationToken);
    Task<object> UnLockedUser(Guid UserAccountId, CancellationToken cancellationToken);
}
