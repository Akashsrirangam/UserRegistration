using UserModel.User;

namespace UserCore.Interface
{
    public interface IUserPut
    {
        void PutUser(int userId, UserRegistrationModel userModel);
    }
}