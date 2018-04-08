using KolaNaukowe.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Data
{
    public class DbInitializer
    {
        public static void Initialize(KolaNaukoweDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any groups.
            if (context.StudentResearchGroups.Any())
            {
                return;   // DB has been seeded
            }

            var students = new StudentResearchGroup[]
            {
            new StudentResearchGroup{Name="EKA.NET",CreatedAt=DateTime.UtcNow,Department = "Elektroniki"},
            new StudentResearchGroup{Name="PIAST.NET",CreatedAt=DateTime.UtcNow,Department = "Informatyki i Zarzadzania"},
            new StudentResearchGroup{Name="NEW.NET",CreatedAt=DateTime.UtcNow, Department = "Mechaniczny"},
            new StudentResearchGroup{Name="COS.NET",CreatedAt=DateTime.UtcNow, Department = "Elektryczny"},
            };

            foreach (StudentResearchGroup s in students)
            {
                context.StudentResearchGroups.Add(s);
            }
            context.SaveChanges();
        }
    }
}
