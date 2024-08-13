using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCore.Interface;
using UserInfrastructure;
using UserInfrastructure.Table;
using UserModel.User;

namespace UserCore.Implementation
{
    public class UserPost : IUserPost
    {

        private readonly UserDBcontext _userDBcontext;

        public UserPost(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public bool PostUser(UserRegistrationModel userModel)
        {
            var userCheck = _userDBcontext.User
                .Where(i => i.EmailId == userModel.EmailId).FirstOrDefault();

            if (userCheck==null)
            {
                var user = new User()
                {
                    FirstName = userModel.FirstName,
                    LastName = userModel.LastName,
                    EmailId = userModel.EmailId,
                    Password = userModel.Password,
                    ContactNumber = userModel.ContactNumber,
                    City = userModel.City,
                    RoleMasterId = userModel.RoleMasterId,  

                };
                _userDBcontext.User.Add(user);
                _userDBcontext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
