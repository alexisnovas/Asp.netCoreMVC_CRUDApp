using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVC_CRUD.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string GradeName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
