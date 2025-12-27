using Student_Assessment_System_with_Item_Analysis.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System_with_Item_Analysis.Source.Managers
{
    public class ScoringManager
    {
        public TestResult CalculateScore(int testInstanceId, int studentId)
        {
            // Implement automatic scoring
            return new TestResult();
        }

        public decimal CalculatePercentage(decimal rawScore, decimal totalPoints)
        {
            return (rawScore / totalPoints) * 100;
        }

        public string CalculateLetterGrade(decimal percentage)
        {
            if (percentage >= 90) return "A";
            if (percentage >= 80) return "B";
            if (percentage >= 70) return "C";
            if (percentage >= 60) return "D";
            return "F";
        }
    }
}