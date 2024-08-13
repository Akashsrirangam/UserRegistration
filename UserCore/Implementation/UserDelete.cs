using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCore.Interface;
using UserInfrastructure;
using UserModel.User;

namespace UserCore.Implementation
{
    public class UserDelete : IUserDelete
    {

        private readonly UserDBcontext _userDBcontext;

        public UserDelete(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void DeleteUser(int userId)
        {
            var userInfo = _userDBcontext.User.Where(i => i.UserId == userId).FirstOrDefault();
            if (userInfo != null)
            {
                _userDBcontext.User.Remove(userInfo);
                _userDBcontext.SaveChanges();
            }
        }
    }
}
