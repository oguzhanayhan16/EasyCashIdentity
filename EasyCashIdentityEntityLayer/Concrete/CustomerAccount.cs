﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        [Key]
        public int CustomerAccountID { get; set; }

        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountCurrency { get; set; }
        public string BankBranch { get; set; }
        public decimal CustomerAccountBalance { get; set; }

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

        public List<CustomerAccountProcess> CustomerSender { get; set; }
        public List<CustomerAccountProcess> CustomerReceiver { get; set; }


    }
}
