namespace Student_Assessment_System_with_Item_Analysis.Source.Models
{
    public class Admin : User
    {
        public Admin()
        {
            SetRole();
        }

        public override void SetRole()
        {
            this.UserRole = "Admin";
        }
    }
}