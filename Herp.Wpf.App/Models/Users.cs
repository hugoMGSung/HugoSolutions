using System;

namespace Herp.Wpf.App.Models
{
    public class Users
    {
        public int Idx { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public char UserYn { get; set; }
        public DateTime LoginDt { get; set; }
        public DateTime RegDt { get; set; }
        public string RedId { get; set; }
        public DateTime ModDt { get; set; }
        public string ModId { get; set; }
    }
}
