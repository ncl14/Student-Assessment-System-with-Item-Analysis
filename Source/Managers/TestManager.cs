using Student_Assessment_System_with_Item_Analysis.Database;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Source.Managers
{
    public class TestManager
    {
        public void SomeMethod()
        {
            using (SqlConnection conn = DatabaseContext.GetConnection())
            {
                conn.Open();
                // database logic here
            }
        }
    }
}
