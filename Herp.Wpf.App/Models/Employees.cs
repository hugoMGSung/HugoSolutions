using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyTools;

namespace Herp.Wpf.App.Models
{
    public class Employees : Observable
    {
        private int idx;
        private string firstName;
        private string lastName;
        private string address;
        private string mobileNo;
        private string email;
        private string nid;
        private string bloodGroup;
        private string religion;
        private string education;
        private decimal salary;
        private string comment;
        private DateTime joinDate;

        public int Idx
        {
            get => idx;
            set => SetValue(ref idx, value, "Idx");
        }

        public string FirstName
        {
            get => firstName;
            set => SetValue(ref firstName, value, "FirstName");
        }

        public string LastName
        {
            get => lastName;
            set => SetValue(ref lastName, value, "LastName");
        }

        public string Address
        {
            get => address;
            set => SetValue(ref address, value, "Address");
        }

        public string MobileNo
        {
            get => mobileNo;
            set => SetValue(ref mobileNo, value, "MobileNo");
        }

        public string Email
        {
            get => email;
            set => SetValue(ref email, value, "Email");
        }

        public string NID
        {
            get => nid;
            set => SetValue(ref nid, value, "NID");
        }

        public string BloodGroup
        {
            get => bloodGroup;
            set => SetValue(ref bloodGroup, value, "BloodGroup");
        }

        public string Religion
        {
            get => religion;
            set => SetValue(ref religion, value, "Religion");
        }

        public string Education
        {
            get => education;
            set => SetValue(ref education, value, "Education");
        }

        public decimal Salary
        {
            get => salary;
            set => SetValue(ref salary, value, "Salary");
        }
        public string Comment
        {
            get => comment;
            set => SetValue(ref comment, value, "Comment");
        }
        public DateTime JoinDate
        {
            get => joinDate;
            set => SetValue(ref joinDate, value, "JoinDate");
        }
    }
}
