using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class QuestionStatistics
    {
        public int QuestionId { get; set; }
        public int CorrectCount { get; set; }
        public int TotalResponses { get; set; }

        public double DifficultyIndex =>
            TotalResponses == 0 ? 0 : (double)CorrectCount / TotalResponses;
    }
}