using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure.Table;

namespace UserInfrastructure
{
    public class UserDBcontext : DbContext
    {
        public UserDBcontext(DbContextOptions<UserDBcontext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<RoleMaster> RoleMaster {  get; set; }
    }
}
