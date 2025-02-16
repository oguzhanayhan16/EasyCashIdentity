using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCashIdentity.EntityLayer.Concrete;

namespace EasyCashIdentity.DataAccesLayer.Abstract
{
    public interface ICustomerAccountProcess:IGenericDal<CustomerAccountProcess>
    {
        List<CustomerAccountProcess> MyLastProcess(int id);
    }
}
