namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class Subject
    {
        // These names must match your Database Columns exactly!
        public int SubjectID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int Units { get; set; }
        public string Description { get; set; }
    }
}