using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVC_CRUD.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }
        public Grade Grade { get; set; } //Esto generará un foreign key pero nullable.

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
