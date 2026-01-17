//using Student_Assessment_System_with_Item_Analysis.Source.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Student_Assessment_System_with_Item_Analysis.Source.Managers
//{
//    public class ItemAnalysisManager
//    {
//        public double CalculateDifficulty(int correctCount, int totalCount)
//        {
//            return (double)correctCount / totalCount;
//        }

//        public string InterpretDifficulty(double pValue)
//        {
//            if (pValue > 0.75) return "Easy";
//            if (pValue >= 0.25) return "Average/Moderate";
//            return "Difficult";
//        }

//        public List<QuestionStatistics> PerformItemAnalysis(int testInstanceId)
//        {
//            var statsList = new List<QuestionStatistics>();

//      ////      using (SqlConnection conn = DatabaseContext.GetConnection())
//      //      {
//      //          conn.Open();

//      //          // 1. Fetch all TestResults to rank students
//      //          var results = new List<TestResult>();
//      //          string resultQuery = "SELECT StudentID, RawScore FROM TestResults WHERE TestInstanceID = @TID ORDER BY RawScore DESC";
//      //          using (SqlCommand cmd = new SqlCommand(resultQuery, conn))
//      //          {
//      //              cmd.Parameters.AddWithValue("@TID", testInstanceId);
//      //              using (SqlDataReader r = cmd.ExecuteReader())
//      //              {
//                        while (r.Read())
//                        {
//                            results.Add(new TestResult
//                            {
//                                StudentID = (int)r["StudentID"],
//                                RawScore = (decimal)r["RawScore"]
//                            });
//                        }
//                    }
//                }

//                int totalStudents = results.Count;
//                if (totalStudents == 0) return statsList;

//                // 2. Define Upper and Lower Groups (27% Rule)
//                int groupSize = (int)Math.Ceiling(totalStudents * 0.27);
//                // If small sample, fallback to 33% or 50%? 
//                // Spec says "minimum 30 students" required for valid analysis, but code should run regardless.
//                // If groupSize is 0 (e.g. 1 student), make it 1.
//                if (groupSize == 0 && totalStudents > 0) groupSize = 1;

//                var upperGroupIds = results.Take(groupSize).Select(r => r.StudentID).ToHashSet();
//                var lowerGroupIds = results.Skip(totalStudents - groupSize).Select(r => r.StudentID).ToHashSet();

//                // 3. Fetch all Answers for this instance
//                var answers = new List<StudentAnswer>();
//                string ansQuery = "SELECT StudentID, QuestionID, IsCorrect FROM StudentAnswers WHERE TestInstanceID = @TID";
//                using (SqlCommand cmd = new SqlCommand(ansQuery, conn))
//                {
//                    cmd.Parameters.AddWithValue("@TID", testInstanceId);
//                    using (SqlDataReader r = cmd.ExecuteReader())
//                    {
//                        while (r.Read())
//                        {
//                            answers.Add(new StudentAnswer
//                            {
//                                StudentID = (int)r["StudentID"],
//                                QuestionID = (int)r["QuestionID"],
//                                IsCorrect = (bool)r["IsCorrect"]
//                            });
//                        }
//                    }
//                }

//                // 4. Group by Question and Calculate Indices
//                var answersByQuestion = answers.GroupBy(a => a.QuestionID);

//                foreach (var qGroup in answersByQuestion)
//                {
//                    int qID = qGroup.Key;
//                    var qAnswers = qGroup.ToList();

//                    int totalResponses = qAnswers.Count;
//                    int totalCorrect = qAnswers.Count(a => a.IsCorrect);

//                    // Difficulty Index (P)
//                    decimal pVal = totalResponses > 0
//                        ? (decimal)totalCorrect / totalResponses
//                        : 0;

//                    // Discrimination Index (D)
//                    // D = (Ru - Rl) / Ng
//                    // Ru = # correct in Upper Group
//                    // Rl = # correct in Lower Group
//                    // Ng = # students in one group (groupSize)

//                    int upperCorrect = qAnswers.Count(a => upperGroupIds.Contains(a.StudentID) && a.IsCorrect);
//                    int lowerCorrect = qAnswers.Count(a => lowerGroupIds.Contains(a.StudentID) && a.IsCorrect);

//                    decimal dVal = 0;
//                    if (groupSize > 0)
//                    {
//                        dVal = (decimal)(upperCorrect - lowerCorrect) / groupSize;
//                    }

//                    // Create Stats Object
//                    var stat = new QuestionStatistics
//                    {
//                        QuestionID = qID,
//                        TestInstanceID = testInstanceId,
//                        DifficultyIndex = pVal,
//                        DiscriminationIndex = dVal,
//                        TotalResponses = totalResponses,
//                        CorrectResponses = totalCorrect,
//                        CalculatedDate = DateTime.Now
//                    };
//                    statsList.Add(stat);

//                    // 5. Persist to DB
//          //          SaveStatistics(stat, conn);
//                }
//            }

//            return statsList;
//        }

//        //private void SaveStatistics(QuestionStatistics stat, SqlConnection conn)
//        //{
//        //    // Check if exists
//        //    string checkSql = "SELECT COUNT(*) FROM QuestionStatistics WHERE QuestionID = @QID AND TestInstanceID = @TID";
//        //    using (SqlCommand cmd = new SqlCommand(checkSql, conn))
//        //    {
//        //        cmd.Parameters.AddWithValue("@QID", stat.QuestionID);
//        //        cmd.Parameters.AddWithValue("@TID", stat.TestInstanceID);
//        //        int exists = (int)cmd.ExecuteScalar();

//        //        if (exists > 0)
//        //        {
//        //            // Update
//        //            string updateSql = @"UPDATE QuestionStatistics 
//        //                SET DifficultyIndex = @Diff, DiscriminationIndex = @Disc, 
//        //                    TotalResponses = @Tot, CorrectResponses = @Corr, CalculatedDate = GETDATE()
//        //                WHERE QuestionID = @QID AND TestInstanceID = @TID";

//        //            using (SqlCommand up = new SqlCommand(updateSql, conn))
//        //            {
//        //                up.Parameters.AddWithValue("@Diff", stat.DifficultyIndex);
//        //                up.Parameters.AddWithValue("@Disc", stat.DiscriminationIndex);
//        //                up.Parameters.AddWithValue("@Tot", stat.TotalResponses);
//        //                up.Parameters.AddWithValue("@Corr", stat.CorrectResponses);
//        //                up.Parameters.AddWithValue("@QID", stat.QuestionID);
//        //                up.Parameters.AddWithValue("@TID", stat.TestInstanceID);
//        //                up.ExecuteNonQuery();
//        //            }
//        //        }
//        //        else
//        //        {
//        //            // Insert
//        //            string insertSql = @"INSERT INTO QuestionStatistics 
//        //                (QuestionID, TestInstanceID, DifficultyIndex, DiscriminationIndex, TotalResponses, CorrectResponses)
//        //                VALUES (@QID, @TID, @Diff, @Disc, @Tot, @Corr)";

//        //            using (SqlCommand ins = new SqlCommand(insertSql, conn))
//        //            {
//        //                ins.Parameters.AddWithValue("@QID", stat.QuestionID);
//        //                ins.Parameters.AddWithValue("@TID", stat.TestInstanceID);
//        //                ins.Parameters.AddWithValue("@Diff", stat.DifficultyIndex);
//        //                ins.Parameters.AddWithValue("@Disc", stat.DiscriminationIndex);
//        //                ins.Parameters.AddWithValue("@Tot", stat.TotalResponses);
//        //                ins.Parameters.AddWithValue("@Corr", stat.CorrectResponses);
//        //                ins.ExecuteNonQuery();
//        //            }
//                }
//            }
