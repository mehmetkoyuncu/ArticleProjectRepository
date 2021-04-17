using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEverything.ArticleService.Data.Entitites.Account;

namespace WriteEverything.ArticleService.Data.Entitites.Contexts.EntityFramework
{
    public class UserContext : DbContext
    {
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<BasicInformation> BasicInformations { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<Followers> Followers { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
    }
}
