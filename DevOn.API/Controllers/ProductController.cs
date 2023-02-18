using DevOn.API.Filters;
using DevOn.API.Interfaces;
using DevOn.API.ViewModels;
using DevOn.Business.Interfaces;
using DevOn.Business.Models;
using DevOn.Business.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

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

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public void Get(int id)
        {
           // return .Get(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] ProductVM pro)
        {
            _productService.AddProduct(pro);
            return Ok();

        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
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
