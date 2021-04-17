using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEverything.UserService.Data.Entities.Base;

namespace WriteEverything.UserService.Data.Entities
{
    public class Followers:BaseEntity
    {
        public virtual Account Account { get; set; }
        public Account FollowerId { get; set; }
        public virtual Account Follower { get; set; }
    }
}
