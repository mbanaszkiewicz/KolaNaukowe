using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int StudentResearchGroupId { get; set; }
        
        public virtual StudentResearchGroup StudentResearchGroup { get; set; }
      
    }
}
