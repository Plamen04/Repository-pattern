using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Repository_pattern_library.Models;

namespace Repository_pattern_library
{
    public class PatternContext:DbContext
    {
        public PatternContext(DbContextOptions<PatternContext> options):base(options)
        {
            
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Shifts> Shifts { get; set; }
    }
}
