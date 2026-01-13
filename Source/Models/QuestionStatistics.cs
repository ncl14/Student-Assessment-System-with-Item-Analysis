using System;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class QuestionStatistics
    {
        public int StatID { get; set; }
        public int QuestionID { get; set; }
        public int TestInstanceID { get; set; }
        public decimal DifficultyIndex { get; set; }
        public decimal DiscriminationIndex { get; set; }
        public int TotalResponses { get; set; }
        public int CorrectResponses { get; set; }
        public DateTime CalculatedDate { get; set; }
        
        // Interpretation Helpers
        public string DifficultyInterpretation
        {
            get
            {
                if (DifficultyIndex > 0.75m) return "Easy";
                if (DifficultyIndex >= 0.25m) return "Average";
                return "Difficult";
            }
        }

        public string DiscriminationInterpretation
        {
            get
            {
                if (DiscriminationIndex >= 0.40m) return "Very Good";
                if (DiscriminationIndex >= 0.30m) return "Reasonably Good";
                if (DiscriminationIndex >= 0.20m) return "Marginal";
                return "Poor";
            }
        }
    }
}