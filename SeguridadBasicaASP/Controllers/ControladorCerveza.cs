using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeguridadBasicaASP.Models;
using SeguridadBasicaASP.Services;

namespace SeguridadBasicaASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ControladorCerveza : ControllerBase
    {
        private readonly IServicioCerveza _servicioCerveza;
        private readonly ILogger<ControladorCerveza> _logger;
        public ControladorCerveza(IServicioCerveza servicioCerveza, ILogger<ControladorCerveza> logger)
        {
            _servicioCerveza = servicioCerveza;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Cerveza>> Get() => await _servicioCerveza.Get();
    }
}
