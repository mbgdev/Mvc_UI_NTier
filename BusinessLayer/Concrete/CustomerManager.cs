using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDAL _customerDAL;
                  
        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }

        public void TInsert(Customer item)
        {
            _customerDAL.Insert(item);
        }

        public void TDelete(Customer item)
        {
            _customerDAL.Delete(item);
        }

        public Customer TGetById(int id)
        {
            return _customerDAL.GetById(id);    
        }

        public List<Customer> TGetList()
        {
            return _customerDAL.GetList();

        }

        public void TUpdate(Customer item)
        {
            _customerDAL.Update(item);

        }
    }
}
