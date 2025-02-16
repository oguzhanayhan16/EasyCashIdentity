using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCashIdentity.BusinessLayer.Abstract;
using EasyCashIdentity.DataAccesLayer.Abstract;
using EasyCashIdentity.EntityLayer.Concrete;

namespace EasyCashIdentity.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcess _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcess customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProcess t)
        {
            throw new NotImplementedException();
        }

        public CustomerAccountProcess TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerAccountProcess> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(CustomerAccountProcess t)
        {
            throw new NotImplementedException();
        }
        public List<CustomerAccountProcess> TMyLastProcess(int id)
        {
            return _customerAccountProcessDal.MyLastProcess(id);
        }

        public void TUpdate(CustomerAccountProcess t)
        {
            throw new NotImplementedException();
        }
    }
}
