using CatHelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatHelp.Date
{
    public interface  IRepoCat
    {
        bool SaveChanges();

        IEnumerable<Cat> GetAllCat();
        Cat GetCatById(int id);
        void CreateCat(Cat  cat);
        void UpdateCat(Cat cat);
        void DeleteCat(Cat cat);
    }
}
