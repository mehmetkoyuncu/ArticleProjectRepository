using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteEverything.UserService.Data.Entities.Base
{
    public abstract class BaseEntity
    {
        public Guid AccountId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Account CreatedAccount { get; set; }
        public int CreatedAccountId { get; set; }
    }
}
