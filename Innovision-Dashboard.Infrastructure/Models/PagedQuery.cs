namespace Innovision_Dashboard.Infrastructure.Models;
public class PagedQuery
{
    public string? Search { get; set; }
    public int PageNumber { get; set; } = 0;
    public int PageSize { get; set; } = 10;
    public bool? SortOrder { get; set; } = true;

    public int SkipCount
    {
        get => (PageNumber > 0 ? PageNumber : 0) * (PageSize > 0 ? PageSize : 10);
    }
}

