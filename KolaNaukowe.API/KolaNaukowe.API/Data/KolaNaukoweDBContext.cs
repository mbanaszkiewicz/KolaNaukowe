using KolaNaukowe.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.API.Data
{
    public class KolaNaukoweDBContext : DbContext
    {
        public KolaNaukoweDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StudentResearchGroup> StudentResearchGroups { get; set; }
    }
}
