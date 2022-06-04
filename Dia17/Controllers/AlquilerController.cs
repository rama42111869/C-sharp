using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dia17.Models.Response;
using Dia17.Models;
using Dia17.Models.Request;

namespace Dia17.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (Dia17Context db = new Dia17Context())
                {
                    var lst = db.Alquilers.ToList();
                    respuesta.Exito = 200;
                    respuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }
    }

}
