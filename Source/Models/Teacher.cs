namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class Teacher : User
    {
        public Teacher()
        {
            SetRole();
        }

        public override void SetRole()
        {
            this.UserRole = "Teacher";
        }
    }
}