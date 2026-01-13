using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public abstract class Question
    {
        public int QuestionID { get; set; }
        public int TestID { get; set; }
        public string QuestionText { get; set; }
        public decimal Points { get; set; }
        public string DifficultyLevel { get; set; }
        public string CognitiveLevel { get; set; }
        public string Topic { get; set; }

        public abstract bool ValidateAnswer(object answer);
    }
    public class MultipleChoiceQuestion : Question
    {
        public List<QuestionChoice> Choices { get; set; }

        public override bool ValidateAnswer(object answer)
        {
            if (answer is int selectedChoiceId)
            {
                var correctChoice = Choices.FirstOrDefault(c => c.IsCorrect);
                return correctChoice != null && correctChoice.ChoiceID == selectedChoiceId;
            }
            return false;
        }
    }

    public class QuestionChoice
    {
        public int ChoiceID { get; set; }
        public int QuestionID { get; set; }
        public string ChoiceText { get; set; }
        public bool IsCorrect { get; set; }
        public int DisplayOrder { get; set; }
    }
}
