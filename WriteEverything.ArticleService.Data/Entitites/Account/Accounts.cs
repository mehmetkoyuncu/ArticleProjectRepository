﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEverything.ArticleService.Data.Entitites.Account.Base;

namespace WriteEverything.ArticleService.Data.Entitites.Account
{
    public class Accounts : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsEmailHidden { get; set; }
        public bool IsEmailApproved { get; set; }
        public bool IsPhoneNumberApproved { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public bool IsAdmin { get; set; }

    }
}
