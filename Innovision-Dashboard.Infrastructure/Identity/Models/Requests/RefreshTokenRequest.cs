namespace Innovision_Dashboard.Infrastructure.Identity.Models.Requests;

public class RefreshTokenRequest
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
}
