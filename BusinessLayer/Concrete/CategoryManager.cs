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
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void ChangeStatusToTrue()
        {
            throw new NotImplementedException();
        }

        public void TDelete(Category item)
        {
            _categoryDAL.Delete(item);
        }

        public Category TGetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public List<Category> TGetList()
        {
           return  _categoryDAL.GetList();
        }

        public void TInsert(Category item)
        {
            _categoryDAL.Insert(item);
        }

        public void TUpdate(Category item)
        {
            _categoryDAL.Update(item);
        }
    }
}
