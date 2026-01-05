using Student_Assessment_System_with_Item_Analysis.Source.Repositories;

namespace Student_Assessment_System_with_Item_Analysis.Source.Managers.Users
{
    public class UserManager
    {
        private readonly UserRepository _repo = new UserRepository();

        //public List<User> GetAllUsers() => _repo.GetAll();

        //public void CreateUser(User user)
        //{
        //    user.PasswordHash = PasswordHasher.Hash("123456");
        //    _repo.Insert(user);
        //}

        //public void DeactivateUser(int userId)
        //{
        //    _repo.SetActive(userId, false);
        //}
        //private void LoadUsers()
        //{
        //    var manager = new UserManager();
        //    dgvUsers.DataSource = manager.GetAllUsers();
        //}
    }
}