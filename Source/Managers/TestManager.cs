using Student_Assessment_System_with_Item_Analysis.Database;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Source.Managers
{
    public class TestManager
    {
        public int SaveTest(Test test)
        {
            using (SqlConnection conn = DatabaseContext.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Insert Test
                    string insertTestSql = @"
                        INSERT INTO Tests (TestTitle, Description, SubjectID, TestType, DurationMinutes, PassingScore, TotalPoints, CreatedBy, CreatedDate, IsActive)
                        VALUES (@Title, @Desc, @SubjID, @Type, @Dur, @Pass, @Points, @CreatedBy, GETDATE(), 1);
                        SELECT SCOPE_IDENTITY();";

                    int testId;
                    using (SqlCommand cmd = new SqlCommand(insertTestSql, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Title", test.Testtitle);
                        cmd.Parameters.AddWithValue("@Desc", test.Description ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@SubjID", test.SubjectID);
                        cmd.Parameters.AddWithValue("@Type", test.TestType);
                        cmd.Parameters.AddWithValue("@Dur", test.DurationMinutes);
                        cmd.Parameters.AddWithValue("@Pass", test.PassingScore);
                        cmd.Parameters.AddWithValue("@Points", test.TotalPoints);
                        cmd.Parameters.AddWithValue("@CreatedBy", 1); // TODO: Get actual current user ID
                        
                        testId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Insert Questions
                    foreach (var q in test.Questions)
                    {
                        var mq = q as MultipleChoiceQuestion;
                        if (mq == null) continue;

                        string insertQSql = @"
                            INSERT INTO Questions (TestID, QuestionText, QuestionType, Points, DifficultyLevel, CognitiveLevel, Topic)
                            VALUES (@TestID, @Text, 'MultipleChoice', @Points, @Diff, @Cog, @Topic);
                            SELECT SCOPE_IDENTITY();";

                        int questionId;
                        using (SqlCommand cmdQ = new SqlCommand(insertQSql, conn, transaction))
                        {
                            cmdQ.Parameters.AddWithValue("@TestID", testId);
                            cmdQ.Parameters.AddWithValue("@Text", mq.QuestionText);
                            cmdQ.Parameters.AddWithValue("@Points", mq.Points);
                            cmdQ.Parameters.AddWithValue("@Diff", mq.DifficultyLevel ?? (object)DBNull.Value);
                            cmdQ.Parameters.AddWithValue("@Cog", mq.CognitiveLevel ?? (object)DBNull.Value);
                            cmdQ.Parameters.AddWithValue("@Topic", mq.Topic ?? (object)DBNull.Value);

                            questionId = Convert.ToInt32(cmdQ.ExecuteScalar());
                        }

                        // 3. Insert Choices
                        if (mq.Choices != null)
                        {
                            foreach (var c in mq.Choices)
                            {
                                string insertChoiceSql = @"
                                    INSERT INTO QuestionChoices (QuestionID, ChoiceText, IsCorrect, DisplayOrder)
                                    VALUES (@QID, @Text, @Correct, 0)";

                                using (SqlCommand cmdC = new SqlCommand(insertChoiceSql, conn, transaction))
                                {
                                    cmdC.Parameters.AddWithValue("@QID", questionId);
                                    cmdC.Parameters.AddWithValue("@Text", c.ChoiceText);
                                    cmdC.Parameters.AddWithValue("@Correct", c.IsCorrect);
                                    cmdC.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    transaction.Commit();
                    return testId;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
