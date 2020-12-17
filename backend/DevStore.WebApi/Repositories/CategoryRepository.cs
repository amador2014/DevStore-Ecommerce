using DevStore.WebApi.Contexts;
using DevStore.WebApi.Domains;
using DevStore.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.WebApi.Repositories
{
    public class CategoryRepository : ICategory
    {
        private DevStoreContext dbContext = new DevStoreContext();

        public List<Category> Listar()
        {
            return dbContext.Categories.ToList();    
               
        }
    }
}
