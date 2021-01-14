using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVC_CRUD.Models
{
    public class ClassroomStudent
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
    }
}
