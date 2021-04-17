using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteEverything.UserService.Data.Entities
{
    public class PersonalInformation
    {
        public string AboutMe { get; set; }
        public bool Gender { get; set; }
        public virtual Account Account { get; set; }
    }
}
