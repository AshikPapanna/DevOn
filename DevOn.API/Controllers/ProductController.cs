using DevOn.API.Filters;
using DevOn.API.Interfaces;
using DevOn.API.ViewModels;
using DevOn.Business.Interfaces;
using DevOn.Business.Models;
using DevOn.Business.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevOn.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAllHeaders")]
    [ApiController]
    [Auth]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;
        public ProductController(IProductService productService) {
            _productService = productService;
                }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<ProductVM> Get()
        {
            return _productService.GetAllProducts();
        }

        
        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] ProductVM pro)
        {
            try
            {
                _productService.AddProduct(pro);
                return Ok();
            }
            catch(ValidationException ex)
            {
               return UnprocessableEntity(ex.Message);
            }

        }

       

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return Ok(id);
        }
    }
}
