using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfrastructure.Table
{
    public class User
    {
   
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public string City { get; set; }
        public int RoleMasterId { get; set; }
        
        public RoleMaster RoleMaster { get; set; } 
    }
}
