using CatHelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatHelp.Date
{
    public class SqlCatRepo : IRepoCat
    {
        private readonly CatContext _catContext;
        public SqlCatRepo(CatContext catContext )
        {
            _catContext=catContext; 
        }
        public void CreateCat(Cat cat)
        {
            if (cat == null)
            {
                throw new ArgumentNullException(nameof(cat));
            }

            _catContext.Cats.Add(cat);
        }

        public void DeleteCat(Cat cat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cat> GetAllCat()
        {
            return _catContext.Cats.ToList();
        }

        public Cat GetCatById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return(_catContext.SaveChanges() >= 0);
        }

        public void UpdateCat(Cat cat)
        {
            throw new NotImplementedException();
        }
    }
}
