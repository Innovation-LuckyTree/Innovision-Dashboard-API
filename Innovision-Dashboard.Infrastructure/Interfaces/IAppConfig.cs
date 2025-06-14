using Innovision_Dashboard.Infrastructure.Config;
namespace Innovision_Dashboard.Infrastructure.Interfaces;

public interface IAppConfig
{
    string AppId { get; set; }
    string MobileAppId { get; set; }
    string CompanyGameList { get; set; }
    JwtConfig JwtConfig { get; set; }
    IdentityAuthInfo IdentityAuthInfo { get; set; }
    ApiClientConfig CoreIdentityApiClient { get; set; }
    ApiClientConfig CoreApiClient { get; set; }
    ApiClientConfig GameApiClient { get; set; }
    ApiClientConfig AccountServiceApiClient { get; set; }
    ApiClientConfig SupportApiClient { get; set; }
    ApiClientConfig ReportServiceApiClient { get; set; }
    ApiClientConfig PaymentServiceApiClient { get; set; }
}