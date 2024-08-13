using UserModel.User;

namespace UserCore.Interface
{
    public interface IUserPost
    {
        bool PostUser(UserRegistrationModel userModel);
    }
}