using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Listar()
        {
            return Ok( categoryInterface.Listar() );
        }
    }
}