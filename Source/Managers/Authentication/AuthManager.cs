using Student_Assessment_System_with_Item_Analysis.Source.Repositories;

namespace Student_Assessment_System_with_Item_Analysis.Source.Managers.Authentication
{
    public class AuthManager
    {
        private readonly UserRepository _repo = new UserRepository();

        //public User Login(string username, string password)
        //{
        //    var user = _repo.GetByUsername(username);

        //    if (user == null || !user.IsActive)
        //        return null;

        //    if (!PasswordHasher.Verify(password, user.PasswordHash))
        //        return null;

        //    return user;
    }
}
