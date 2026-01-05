using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }

        // Helper property for ComboBox display
        public string FullName => $"{SubjectCode} - {SubjectName}";
    }
}
