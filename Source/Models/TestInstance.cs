using System;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class TestInstance
    {
        public int TestInstanceID { get; set; }
        public int TestID { get; set; }
        public int SectionID { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool IsRandomized { get; set; }
        public bool IsChoicesRandomized { get; set; }
        public bool ShowAnswers { get; set; }
        public bool AllowReview { get; set; }
        public string Status { get; set; }
    }
}
