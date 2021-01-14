using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVC_CRUD.Models
{
    public class StudentGuardian
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int GuardianId { get; set; }
        public Guardian Guardian { get; set; }

    }
}
