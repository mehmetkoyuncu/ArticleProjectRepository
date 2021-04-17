using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEverything.UserService.Data.Entities.Base;

namespace WriteEverything.UserService.Data.Entities
{
    public class BasicInformation:BaseEntityDefinitionId
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Picture { get; set; }
        public virtual Account Account { get; set; }
    }
}
