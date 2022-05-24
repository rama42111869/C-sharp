using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServiceBlazorCrud2.Models.Response;
using WebServiceBlazorCrud2.Models;
using WebServiceBlazorCrud2.Models.Request;

namespace WebServiceBlazorCrud2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CervezaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta respuesta = new Respuesta();
            try { 
            using (BlazorCrudContext db=new BlazorCrudContext())
            {
                var lst = db.Cervezas.ToList();
                respuesta.Exito = 1;
                respuesta.Data = lst;
            }
            }
            catch(Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
                return Ok(respuesta);
        }
        [HttpPost]
        public IActionResult Add(CervezaRequest model)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (BlazorCrudContext db = new BlazorCrudContext())
                {
                    Cerveza cerveza = new Cerveza();
                    cerveza.Marca = model.Marca;
                    cerveza.Nombre = model.Nombre;
                    db.Cervezas.Add(cerveza);
                    db.SaveChanges();
                    respuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }
        [HttpPut]
        public IActionResult Edit(CervezaRequest model)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                using (BlazorCrudContext db = new BlazorCrudContext())
                {
                    Cerveza cerveza = db.Cervezas.Find(model.Id);
                    cerveza.Marca = model.Marca;
                    cerveza.Nombre = model.Nombre;
                    db.Entry(cerveza).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    respuesta.Exito = 1;
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
                using (BlazorCrudContext db = new BlazorCrudContext())
                {
                    Cerveza cerveza = db.Cervezas.Find(Id);
                    db.Remove(cerveza);
                    db.SaveChanges();
                    respuesta.Exito = 1;
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
