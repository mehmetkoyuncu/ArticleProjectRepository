using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEverything.ArticleService.Data.Entitites.Account.Base;

namespace WriteEverything.ArticleService.Data.Entitites.Account
{
    public class PersonalInformation:BaseEntityDefinitionId
    {
        public string AboutMe { get; set; }
        public bool Gender { get; set; }
        public virtual Accounts Account { get; set; }
    }
}
