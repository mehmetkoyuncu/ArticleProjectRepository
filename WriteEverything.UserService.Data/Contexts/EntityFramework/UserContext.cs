using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEverything.UserService.Data.Entities;

namespace WriteEverything.UserService.Data.Contexts.EntityFramework
{
    public class UserContext:DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BasicInformation> BasicInformations { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<Followers> Followers { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
    }
}
