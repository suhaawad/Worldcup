using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace worldcup.Models
{
    public class Transport
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public required int VehicleId {get; set; } // 
        public required TransportType Vehicle { get; set; } // Navigation Property
        public required string Name { get; set; }
        public required string Color { get; set; }
        public required string Image { get; set; }
        public required string Model { get; set; }
        public required string ModelVersion { get; set; }
        public required string Km { get; set; }

    }
}
