using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace worldcup.Models
{
    public class TransportType
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }
        
    }
}