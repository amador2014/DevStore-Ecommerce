using DevStore.WebApi.Domains;
using System.Collections.Generic;

namespace DevStore.WebApi.Interfaces
{
    public interface IProduct
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(int id, Product product);
        void Remove(int id);

    }
}
