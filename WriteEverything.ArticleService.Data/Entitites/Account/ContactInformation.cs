using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEverything.ArticleService.Data.Entitites.Account.Base;

namespace WriteEverything.ArticleService.Data.Entitites.Account
{
    public class ContactInformation : BaseEntityDefinitionId
    {
        public string Address { get; set; }
        public string WebSite { get; set; }
        public string InstagramAddress { get; set; }
        public string TwitterAddress { get; set; }
        public string LinkedinAddress { get; set; }
        public virtual Accounts Account { get; set; }
    }
}
