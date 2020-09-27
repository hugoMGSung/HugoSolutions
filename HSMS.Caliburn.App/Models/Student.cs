using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMS.Caliburn.App.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string Sex { get; set; }
        public int MajorClassIdx { get; set; }

        public virtual MajorClass MajorClass { get; set; }
    }
}
