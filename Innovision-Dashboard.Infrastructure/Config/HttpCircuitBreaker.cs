namespace Innovision_Dashboard.Infrastructure.Config;

public class HttpCircuitBreaker
{
    public string DurationOfBreak { get; set; }
    public int ExceptionAllowedBeforeBreaking { get; set; }
}