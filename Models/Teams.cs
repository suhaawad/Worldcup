using System.ComponentModel.DataAnnotations;

namespace worldcup.Models
{
    public class Teams
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Country { get; set; }
        public required DateTime founded { get; set; }

        public List<Schedule> Schedules { get; set; } = new List<Schedule>(); // Many-to-Many
    }
}