using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swaggerdia18.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        List<Beer> beers = new List<Beer>(){
            new Beer(){Id = 1, Name="Delirium"},
            new Beer(){Id = 2, Name="Corona"},
            new Beer(){Id = 3, Name="Erdinger"},
        };
        [HttpGet]
        public ActionResult<Beer> Elemento(int id)
        {
            var beer= beers.Where(d=>d.Id==id).FirstOrDefault();
            if (beer == null)
            {
                return NotFound();
            }
            return beer;
        }
    }
    class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
