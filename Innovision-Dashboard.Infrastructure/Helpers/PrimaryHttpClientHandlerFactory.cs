namespace Innovision_Dashboard.Infrastructure.Helpers;

using System.Security.Authentication;
public class PrimaryHttpClientHandlerFactory
{
    public static HttpClientHandler CreateHttpClientHandler() => new HttpClientHandler { SslProtocols = SslProtocols.Tls12 };
}