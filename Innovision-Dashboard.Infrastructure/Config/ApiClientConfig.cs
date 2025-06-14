namespace Innovision_Dashboard.Infrastructure.Config;
public class ApiClientConfig
{
    public string BaseAddressUrl { get; set; }
    public string ClientId { get; set; }
    public string Resource { get; set; }
    public string ClientSecret { get; set; }
    public ApiLogging Logging { get; set; }
    public ApiPolicyConfig Policy { get; set; }
}