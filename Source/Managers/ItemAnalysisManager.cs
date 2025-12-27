using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Assessment_System_with_Item_Analysis.Source.Models;

namespace Student_Assessment_System_with_Item_Analysis.Source.Managers
{
    public class ItemAnalysisManager
    {
        public double CalculateDifficulty(int correctCount, int totalCount)
        {
            return (double)correctCount / totalCount;
        }

        public string InterpretDifficulty(double pValue)
        {
            if (pValue > 0.75) return "Easy";
            if (pValue >= 0.25) return "Average/Moderate";
            return "Difficult";
        }

        public List<QuestionStatistics> PerformItemAnalysis(int testInstanceId)
        {
            // Implement item analysis logic
            return new List<QuestionStatistics>();
        }
    }
}