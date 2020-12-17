using DevStore.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.WebApi.Interfaces
{
    public interface ICategory
    {
        List<Category> GetAll();
        Category GetSingle(int id);
        void Add(Category category);
        void Update (int id, Category category);
        void Delete (int id);

    }
}
