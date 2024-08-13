using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure.Table;
using UserInfrastructure;
using UserModel.User;
using UserCore.Interface;

namespace UserCore.Implementation
{
    public class UserPut : IUserPut
    {
        private readonly UserDBcontext _userDBcontext;

        public UserPut(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void PutUser(int userId, UserRegistrationModel userModel)
        {
         
                var userInfo = _userDBcontext.User.Where(i => i.UserId == userId).FirstOrDefault();
                if (userInfo != null)
                {
                    userInfo.FirstName = userModel.FirstName;
                    userInfo.LastName = userModel.LastName;
                    userInfo.EmailId = userModel.EmailId;
                    userInfo.Password = userModel.Password;
                    userInfo.ContactNumber = userModel.ContactNumber;
                    userInfo.City = userModel.City;
                    userInfo.RoleMasterId= userModel.RoleMasterId;
                }
                _userDBcontext.SaveChanges();
                
            }
            
        }
    }

