using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEverything.ArticleService.Data.Entitites.Account.Base;

namespace WriteEverything.ArticleService.Data.Entitites.Account
{
    public class BasicInformation : BaseEntityDefinitionId
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Picture { get; set; }
        public virtual Accounts Account { get; set; }
    }
}
