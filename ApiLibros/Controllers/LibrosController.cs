using ApiLibros.Models;
using ApiLibros.Models.Request;
using ApiLibros.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (LibrosContext db = new LibrosContext())
                {
                    var lst = db.Libros.ToList();
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

        [HttpPost]
        public IActionResult Add(LibrosRequest model)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (LibrosContext db = new LibrosContext())
                {
                    Libros libro = new Libros();
                    libro.Nombre = model.Nombre;
                    libro.NombreLibro = model.NombreLibro;
                    libro.Año = model.Año;
                    db.Libros.Add(libro);
                    db.SaveChanges();
                    respuesta.Exito = 200;
                }
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

        [HttpPut]
        public IActionResult Edit(LibrosRequest model)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (LibrosContext db = new LibrosContext())
                {
                    Libros libro = new Libros();
                    libro.Año = model.Año;
                    libro.NombreLibro = model.NombreLibro;
                    libro.Nombre = model.Nombre;
                    db.Entry(libro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    respuesta.Exito = 200;
                }
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (LibrosContext db = new LibrosContext())
                {
                    Libros libro = db.Libros.Find(Id);
                    db.Remove(libro);
                    db.SaveChanges();
                    respuesta.Exito = 200;
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
