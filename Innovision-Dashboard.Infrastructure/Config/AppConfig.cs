using Innovision_Dashboard.Infrastructure.Interfaces;

namespace Innovision_Dashboard.Infrastructure.Config;

public class AppConfig : IAppConfig
{
    public string AppId { get; set; }
    public string MobileAppId { get; set; }
    public string CompanyGameList { get; set; }
    public JwtConfig JwtConfig { get; set; }
    public IdentityAuthInfo IdentityAuthInfo { get; set; }
    public ApiClientConfig CoreIdentityApiClient { get; set; }
    public ApiClientConfig CoreApiClient { get; set; }
    public ApiClientConfig GameApiClient { get; set; }
    public ApiClientConfig AccountServiceApiClient { get; set; }
    public ApiClientConfig SupportApiClient { get; set; }
    public ApiClientConfig ReportServiceApiClient { get; set; }
    public ApiClientConfig PaymentServiceApiClient { get; set; }
}