using System;
using DevStore.WebApi.Domains;
using DevStore.WebApi.Interfaces;
using DevStore.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DevStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        IProduct ProductInterface {get; set;}
        public ProductController()
        {
            ProductInterface = new ProductRepository();
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(ProductInterface.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                return Ok(ProductInterface.GetById(id));
            }
            catch (Exception exception)
            {
                return BadRequest(new {mesasge = "Aconteceu de errado: " + exception.Message});
            }

        }

        //public IActionResult AddProduct(Product product)
        //{
        //    try
        //    {
        //        if (product == null)
        //            return BadRequest("O produto está nulo");

        //        //CONVERT iMAGEM TO VARBINARY

        //        ProductInterface.Add(product);
        //        return Ok();
        //    }
        //    catch (Exception exception)
        //    {
        //        return BadRequest(new {mesasge = "Aconteceu de errado: " + exception.Message});
        //    }
        //}

        [HttpPut("{id:int}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            try
            {
                if(product == null)
                    return BadRequest("O produto está nulo");

                ProductInterface.Update(id, product);
                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(new {mesasge = "Aconteceu de errado: " + exception.Message});
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult RemoveProduct(int id)
        {
            try
            {
                ProductInterface.Remove(id); 
                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(new {mesasge = "Aconteceu de errado: " + exception.Message});
            }
        }


    }
}