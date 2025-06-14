namespace Innovision_Dashboard.Infrastructure.Identity.Models.Requests;

public class LoginUserRequest
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string IpAddress { get; set; }
}
