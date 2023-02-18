using DevOn.API.Interfaces;
using DevOn.Business.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace DevOn.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAllHeaders")]
    public class AuthController : ControllerBase
    {
        private readonly IKeyService _keyService;
        public AuthController(IKeyService keyService)
        {
            _keyService = keyService;
        }
        [HttpPost("authenticate")]
        public ActionResult<Key> Authenticate(string key)
        {
            if (!_keyService.IsKeyValid(key))
            {
                return Unauthorized();                    
            }
            return _keyService.GetKey();
        }
    }
}
