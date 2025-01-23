namespace worldcup.DTO
{
    public class ScheduleWithStadiumAndTeamsDTO
    {
    public int ScheduleId { get; set; }
    public string StadiumName { get; set; }
    public int StadiumId { get; set; }
    public string StadiumCity { get; set; }
    public DateTime ScheduleDate { get; set; } // For example, adjust to your actual Schedule fields

    public List<string> TeamNames { get; set; } = new List<string>(); // List of team names

    }
}