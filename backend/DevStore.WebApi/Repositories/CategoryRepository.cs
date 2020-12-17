using DevStore.WebApi.Contexts;
using DevStore.WebApi.Domains;
using DevStore.WebApi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DevStore.WebApi.Repositories
{
    public class CategoryRepository : ICategory
    {
        private DevStoreContext dbContext = new DevStoreContext();
        

        public List<Category> GetAll()
        {
            return dbContext.Categories.ToList();    
        }

        public void Add(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }

        public void Update(int id, Category category)
        {
            var oldCategory = dbContext.Categories.Find(id);
            oldCategory.CategoryName = category.CategoryName;
            oldCategory.Description = category.Description;

            dbContext.SaveChanges();;
        }

        public void Delete(int id)
        {
            var returnObj = dbContext.Categories.Find(id);
            dbContext.Categories.Remove(returnObj);
            dbContext.SaveChanges();
        }

        public Category GetSingle(int id)
        {
            return dbContext.Categories.Find(id);
        }
    }
}
