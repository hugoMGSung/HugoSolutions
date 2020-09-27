using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMS.Caliburn.App.Models
{
    public class MajorClass
    {
        public MajorClass()
        {
            this.Students = new HashSet<Student>();
        }

        public int Idx { get; set; }

        public string Name { get; set; }

        public int MajorIdx { get; set; }

        public virtual Major Major { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
