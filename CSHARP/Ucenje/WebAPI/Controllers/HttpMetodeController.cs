﻿using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController : ControllerBase
    {

        [HttpGet]
        [Route("Pozdravi")]
        public string Pozdravi(string s)
        {
            return "Hello " + s;
        }

        [HttpGet]
        [Route("Zbroj")]
        public int Zbroj(int a, int b)
        {
            return a + b;
        }

        [HttpGet]
        [Route("Hello")]
        public IActionResult Pozdravi(int id, string ime)
        {
            return Ok(new{ id = id, ime = ime});
        }

        [HttpPost]
        public IActionResult Post()
        {
            return BadRequest(new { greska = true, poruka = "nešto ne valja" });
        }

        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { greska = true, poruka = "nije dobar parametar" });
            }
            osoba.Prezime = "g. " + osoba.Prezime;
            return StatusCode(StatusCodes.Status206PartialContent, osoba);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return NotFound(new { id = id, poruka = "nije pronađeno", greska = true });
        }
    }
}
