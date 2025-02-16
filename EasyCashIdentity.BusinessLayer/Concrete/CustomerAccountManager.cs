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
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }
        public List<CustomerAccount> TGetCustomerAccountsList(int id)
        {
            return _customerAccountDal.GetCustomerAccountsList(id);
        }
        public void TDelete(CustomerAccount t)
        {
            throw new NotImplementedException();
        }

        public CustomerAccount TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerAccount> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(CustomerAccount t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(CustomerAccount t)
        {
            throw new NotImplementedException();
        }
    }
}
