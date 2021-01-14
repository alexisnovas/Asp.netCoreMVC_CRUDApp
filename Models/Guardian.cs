using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVC_CRUD.Models
{
    public class Guardian
    {
        [Key]
        public int GuardianId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Relationship { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "char(1)")]
        public char Status { get; set; }
        [Column(TypeName = "char(1)")]
        public char Gender { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Phone { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Mobile { get; set; }

        public IList<StudentGuardian> StudentGuardians { get; set; }
    }
}
