using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMS.Caliburn.App.Models
{
    public class SystemUser
    {
        public int Idx { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public int CollegeIdx { get; set; }

        public virtual College College { get; set; }
    }
}
