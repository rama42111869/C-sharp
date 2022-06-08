using AspTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CervezaController : ControllerBase
    {
        private readonly IBeer _beer;

        public CervezaController(IBeer beer)
        {
            _beer = beer;
        }
        [HttpGet]
        public IActionResult Get() => Ok(_beer.Get());
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var beer = _beer.Get(id);
            if (beer == null)
            {
                return NotFound();
            }
            return Ok(beer);
        }
    }
}
