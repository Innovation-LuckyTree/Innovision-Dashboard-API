namespace HappyPlay.Infrastructure.Core.Models.Responses.Users;

public class PlayersVm
{
    public long AccountInfoId { get; set; }
    public Guid AccountObjectId { get; set; }
    public string Fullname { get; set; }
    public string BranchName { get; set; }
    public string MobileNumber { get; set; }
    public int Status { get; set; } = 1;
    public DateTime? CreatedOn { get; set; }
    public DateTime? ApprovedDate { get; set; }
}