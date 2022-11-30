using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_pattern_library.Models
{
    public class Shifts
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }
        public ICollection<Users>? Users { get; set; }
    }
}
