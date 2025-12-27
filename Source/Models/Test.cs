using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class Test
    {
        public int TestID { get; set; }
        public string Testtitle { get; set; }
        public string Description { get; set; }
        public int SubjectID { get; set; }
        public string TestType { get; set; }
        public int DurationMinutes { get; set; }
        public decimal PassingScore { get; set; }
        public decimal TotalPoints { get; set; }
        public List<Question> Questions { get; set; }
    }
}
