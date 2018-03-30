using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.API.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public StudentResearchGroup StudentResearchGroup { get; set; }
    }
}
