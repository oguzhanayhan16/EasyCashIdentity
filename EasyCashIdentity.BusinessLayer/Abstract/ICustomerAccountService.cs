using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCashIdentity.EntityLayer.Concrete;

namespace EasyCashIdentity.BusinessLayer.Abstract
{
    public interface ICustomerAccountService:IGenericService<CustomerAccount>
    {
        public List<CustomerAccount> TGetCustomerAccountsList(int id);
    }
}
