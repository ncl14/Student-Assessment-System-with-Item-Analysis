using System;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public abstract class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string UserRole { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
    public class Teacher : User { }
    public class Student : User { }
}
