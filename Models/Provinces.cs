using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace worldcup.Models
{
    public class Provinces
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }

        public required ICollection<Cities> Cities { get; set; } // One-to-Many

    }
}