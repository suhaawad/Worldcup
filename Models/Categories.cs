using System.ComponentModel.DataAnnotations;

namespace worldcup.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Icon { get; set; }

        public required string Url { get; set; }
        public required string Image { get; set; }

    }
}