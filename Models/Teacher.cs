using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVC_CRUD.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(250)")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "char(1)")]
        public char Status { get; set; }
        [Column(TypeName = "char(1)")]
        public char Gender { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Phone { get; set; }
        public Classroom Classroom { get; set; } /*Automaticamente crea un FK con el nombre
        ClassroomId que la PK de Classroom. A través de esta forma se crea nullable.*/

    }
}
