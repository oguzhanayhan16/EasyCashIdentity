using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCashIdentity.DataAccesLayer.Abstract;
using EasyCashIdentity.DataAccesLayer.Concrete;
using EasyCashIdentity.DataAccesLayer.Repositories;
using EasyCashIdentity.EntityLayer.Concrete;

namespace EasyCashIdentity.DataAccesLayer.EntityFramework
{
    public class EfCustomerAccountDal : GenericRepository<CustomerAccount>, ICustomerAccountDal
    {
        public List<CustomerAccount> GetCustomerAccountsList(int id)
        {
            using var context = new Context();
            var values = context.CustomerAccounts.Where(x => x.AppUserID == id).ToList();
            return values;
        }
    }
}
