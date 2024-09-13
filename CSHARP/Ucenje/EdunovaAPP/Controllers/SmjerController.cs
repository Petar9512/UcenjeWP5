using EdunovaAPP.Models;
using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {

        private readonly EdunovaContext _context;
        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_context.Smjerovi);
        }

        [HttpGet]
        [Route("{sifra:int}")]
        public IActionResult GetBySifra(int sifra)
        {
            return Ok(_context.Smjerovi.Find(sifra));
        }

        [HttpPost]
        public IActionResult Post(Smjer smjer)
        {
            _context.Smjerovi.Add(smjer);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, smjer);
        }

        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Put(int sifra, Smjer smjer)
        {
            var smjerBaza = _context.Smjerovi.Find(sifra);

            smjerBaza.Naziv = smjer.Naziv;
            smjerBaza.Trajanje = smjer.Trajanje;
            smjerBaza.Cijena = smjer.Cijena;
            smjerBaza.IzvodiSeOd = smjer.IzvodiSeOd;
            smjerBaza.Vaucer = smjer.Vaucer;

            _context.Smjerovi.Update(smjerBaza);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno promijenjeno" });
        }

        [HttpDelete]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int sifra)
        {
            var smjerBaza = _context.Smjerovi.Find(sifra);

            _context.Smjerovi.Remove(smjerBaza);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno obrisano" });
        }
    }
}
