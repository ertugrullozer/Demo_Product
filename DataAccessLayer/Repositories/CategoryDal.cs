using DataAccessLayer.Abstract;
using DataAccessLayer.Contcrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryDal : ICategoryDal
    {
        Context c= new Context();
        public void Delete(Category p)
        {
           c.Remove(p);
            c.SaveChanges();
        }

        public List<Category> GetList()
        {
           return c.categories.ToList();
        }

        public void Insert(Category p)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            throw new NotImplementedException();
        }
    }
}
