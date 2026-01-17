using System;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class ReportViewModel
    {
        public int ReportID { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string GeneratedBy { get; set; } // Username
        public string Role { get; set; }        // e.g., Teacher
        public string Status { get; set; }      // e.g., Completed, Pending
        public DateTime DateCreated { get; set; }
    }
}