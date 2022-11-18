using DevStore.WebApi.Contexts;
using DevStore.WebApi.Domains;
using DevStore.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevStore.WebApi.Repositories
{
    public class ProductRepository : IProduct
    {

        DevStoreContext  dbContext = new DevStoreContext();

        public void Add(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public List<Product> GetAll()
        {
            var productsList= dbContext.Products.ToList();
            return productsList;
        }

        public Product GetById(int id)
        {
            return dbContext.Products.Find(id);
        }

        public void Remove(int id)
        {
            dbContext.Products.Remove(GetById(id));
            dbContext.SaveChanges();
        }

        public void Update(int id, Product product)
        {
            var oldProduct = GetById(id);
            oldProduct.ProductName = product.ProductName;
            oldProduct.IsAvaliable = product.IsAvaliable;
            oldProduct.Description = product.Description;
            oldProduct.ProductImage = product.ProductImage;
            oldProduct.IsFeatured = product.IsFeatured;
            oldProduct.PricePerUnity = product.PricePerUnity;
            oldProduct.Stock = product.Stock;
            oldProduct.CategoryId = product.CategoryId;

            dbContext.SaveChanges();
        }
    }
}
