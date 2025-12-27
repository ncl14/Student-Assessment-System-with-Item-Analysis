using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public abstract class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string UserRole { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
    public class Admin : User { }
    public class Teacher : User { }
    public class Student : User { }
}
