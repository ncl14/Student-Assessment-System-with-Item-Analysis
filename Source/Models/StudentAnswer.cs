using System;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class StudentAnswer
    {
        public int AnswerID { get; set; }
        public int TestInstanceID { get; set; }
        public int StudentID { get; set; }
        public int QuestionID { get; set; }
        public int SelectedChoiceID { get; set; }
        public bool IsCorrect { get; set; }
        public int TimeTakenSeconds { get; set; }
    }
}
