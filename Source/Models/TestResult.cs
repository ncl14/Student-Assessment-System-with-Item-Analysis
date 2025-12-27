using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class TestResult
    {
        public int ResultID { get; set; }
        public int TestInstanceID { get; set; }
        public int StudentID { get; set; }
        public decimal RawScore { get; set; }
        public decimal Percentage { get; set; }
        public string LetterGrade { get; set; }
        public DateTime CompletedDate { get; set; }
    }
}
