using System;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public abstract class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }      // Matches database 'UserName'
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }     // Matches database 'FirstName'
        public string LastName { get; set; }      // Matches database 'LastName'
        public string Email { get; set; }         // Matches database 'Email'
        public string UserRole { get; set; }      // Matches database 'UserRole'
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        // Abstract method to set specific role in derived classes
        public abstract void SetRole();
    }
}