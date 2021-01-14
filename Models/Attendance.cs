using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVC_CRUD.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Column(TypeName = "char(1)")]
        public char Status { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Remark { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
