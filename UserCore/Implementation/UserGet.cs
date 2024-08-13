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
    public class UserGet : IUserGet
    {
        private readonly UserDBcontext _userDBcontext;

        public UserGet(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public UserRegistrationModel GetSingleUser(int userId)
        {
            var userinfo = _userDBcontext.User.Where(x => x.UserId == userId)
               .Select(i => new UserRegistrationModel
               {
                   UserId = i.UserId,
                   FirstName = i.FirstName,
                   LastName = i.LastName,
                   EmailId = i.EmailId,
                   Password = i.Password,
                   ContactNumber = i.ContactNumber,
                   City = i.City,
                   RoleMasterId=i.RoleMasterId,
               }).FirstOrDefault();

            return userinfo;

        }
    }
}
