using UserModel.User;

namespace UserCore.Interface
{
    public interface IUserGet
    {
        UserRegistrationModel GetSingleUser(int userId);
    }
}