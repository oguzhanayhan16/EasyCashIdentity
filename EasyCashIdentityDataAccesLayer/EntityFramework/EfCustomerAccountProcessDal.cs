using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCashIdentity.DataAccesLayer.Abstract;
using EasyCashIdentity.DataAccesLayer.Concrete;
using EasyCashIdentity.DataAccesLayer.Repositories;
using EasyCashIdentity.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EasyCashIdentity.DataAccesLayer.EntityFramework
{
    class EfCustomerAccountProcessDal: GenericRepository<CustomerAccountProcess>, ICustomerAccountProcess
    {
        public List<CustomerAccountProcess> MyLastProcess(int id)
        {
            using var context = new Context();
            var values = context.CustomerAccountProcesses.Include(y => y.SenderCustomer).Include(w => w.ReceiverCustomer).ThenInclude(z => z.AppUser).Where(x => x.ReceiverID == id || x.SenderID == id).ToList();
            return values;
        }
    }
}
