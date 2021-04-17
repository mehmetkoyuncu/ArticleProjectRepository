using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEverything.UserService.Data.Entities.Base;

namespace WriteEverything.UserService.Data.Entities
{
    public class ContactInformation:BaseEntityDefinitionId
    {
        public string Address { get; set; }
        public string WebSite { get; set; }
        public string InstagramAddress { get; set; }
        public string TwitterAddress { get; set; }
        public string LinkedinAddress { get; set; }
        public virtual Account Account { get; set; }
    }
}
