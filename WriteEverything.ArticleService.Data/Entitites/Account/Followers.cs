using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEverything.ArticleService.Data.Entitites.Account.Base;

namespace WriteEverything.ArticleService.Data.Entitites.Account
{
    public class Followers : BaseEntity
    {
        public virtual Accounts Account { get; set; }
        public Accounts FollowerId { get; set; }
        public virtual Accounts Follower { get; set; }
    }
}
