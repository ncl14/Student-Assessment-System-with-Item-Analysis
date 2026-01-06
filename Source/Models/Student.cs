namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class Student : User
    {
        public Student()
        {
            SetRole();
        }

        public override void SetRole()
        {
            this.UserRole = "Student";
        }
    }
}