using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public StudentResearchGroup StudentResearchGroup { get; set; }
    }
}
