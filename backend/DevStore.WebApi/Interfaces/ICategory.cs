using DevStore.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevStore.WebApi.Interfaces
{
    public interface ICategory
    {
        List<Category> Listar();

    }
}
