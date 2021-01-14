using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVC_CRUD.Models
{
    public class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(8)")]
        public string Code { get; set; }
        [Column(TypeName = "char(2)")]
        public string Section { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Remarks { get; set; }
        public Grade Grade { get; set; } //Esto generará un foreign key pero nullable.

        public IList<ClassroomStudent> ClassroomStudents { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
