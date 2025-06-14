namespace Innovision_Dashboard.Infrastructure.Game.Models.Response;

public class CompanyGameListResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string CompanyId { get; set; }
    public Game Game { get; set; }
    public string Description { get; set; }
    public string IsPlayable { get; set; }
    public CompanyGameMechanics Mechanics { get; set; }
}

public class CompanyGameMechanics
{
    public int WinAmount { get; set; }
    public int StraightLimit { get; set; }
    public int RumbleAmount { get; set; }
}