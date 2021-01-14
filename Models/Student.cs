using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVC_CRUD.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string FullName { get; set; }
        public int Age { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Gender { get; set; }
        /*[ForeignKey("GradeRefId")] También se puede utilizar este DataAnnotation cuando
        se quiera poner al FK un nombre distinto que no necesariamente tenga que coincidir
        con el nombre de la tabla original.*/
        public int GradeId { get; set; }  /*Declarando el foreign key de esta forma, más añadiendo
        un navigation collection property de students en la clase Grade el campo se crea en la 
        base de datos como Not null.*/
        public Grade Grade { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Phone { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Nationality { get; set; }

        public IList<StudentCourse> StudentCourses {get; set;}
        public IList <ClassroomStudent> ClassroomStudents { get; set; }

        public IList<StudentGuardian> StudentGuardians { get; set; }

        public ICollection<Attendance> Attendances { get; set; }
    }

}
