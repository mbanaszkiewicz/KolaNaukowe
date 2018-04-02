using KolaNaukowe.web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Data
{
    public class KolaNaukoweDbContext : DbContext
    {
        public KolaNaukoweDbContext(DbContextOptions<KolaNaukoweDbContext> options):base(options) 
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StudentResearchGroup> StudentResearchGroups { get; set; }
    }
}
