
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace worldcup.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        public required DateTime MatchDateTime { get; set; }


        public required int StadiumId { get; set; } // Navigation Property
        public required Stadiums Stadium { get; set; } // Navigation Property

        public List<Teams> Teams { get; set; } = new List<Teams>(); // Many-to-Many


    }
    
}


