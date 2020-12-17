using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevStore.WebApi.Domains;
using DevStore.WebApi.Interfaces;
using DevStore.WebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private ICategory categoryInterface {get; set; }
        public CategoryController()
        {
            categoryInterface = new CategoryRepository();
        }


        [HttpGet]
        public IActionResult GetAllCategories()
        {
            return Ok( categoryInterface.GetAll() );
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            try
            {
                if(category == null)
                    return BadRequest("Categoria nula");

                categoryInterface.Add(category);
                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(new { message = "Erro ao cadastrar: " + exception.Message});
            }

        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateCategory(int id, Category category)
        {
            try
            {
                if(category == null) // || !ModelState.IsValid
                    return BadRequest("Categoria nula");

                categoryInterface.Update(id, category);
                return Ok();

            }catch(Exception exception)
            {
                return BadRequest(new { message = "Erro ao atualizar: " + exception.Message});
            }

        }

        [HttpDelete("{id:int}")]
        public IActionResult RemoveCategory(int id)
        {
            try
            {
                if(categoryInterface.GetSingle(id) == null)
                    return BadRequest("Categoria não existente");

                categoryInterface.Delete(id);
                return Ok();

            }catch(Exception exception)
            {
                return BadRequest(new { message = "Erro ao excluir: " + exception.Message});
            }
        }

    }
}