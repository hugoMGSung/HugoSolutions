using System.Collections.Generic;

namespace HSMS.Caliburn.App.Models
{
    public class Major
    {
        public Major()
        {
            this.MajorClasses = new HashSet<MajorClass>();
        }

        public int Idx { get; set; }

        public string Name { get; set; }

        public int CollegeIdx { get; set; }

        public virtual College College { get; set; }

        public virtual ICollection<MajorClass> MajorClasses { get; set; }
    }
}
