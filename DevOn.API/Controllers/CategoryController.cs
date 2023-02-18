using DevOn.API.Filters;
using DevOn.API.Interfaces;
using DevOn.Business.Interfaces;
using DevOn.Business.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevOn.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAllHeaders")]
    [ApiController]
    [Auth]
    public class CategoryController : ControllerBase
    {
        public readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService) {
            _categoryService = categoryService;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<CategoryVM> Get()
        {
            return _categoryService.GetAllCategory();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
