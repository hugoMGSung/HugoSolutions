using System.Collections.Generic;

namespace HSMS.Caliburn.App.Models
{
    public class College
    {
        public int Idx { get; set; }

        public string Name { get; set; }

        public College()
        {
            this.Majors = new HashSet<Major>();
            this.SystemUsers = new HashSet<SystemUser>();
        }

        public virtual ICollection<Major> Majors { get; set; }

        public virtual ICollection<SystemUser> SystemUsers { get; set; }
    }
}
