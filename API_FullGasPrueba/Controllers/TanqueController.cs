using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FullGas.Core.Interfaces;
using FullGas.Core.Entities;

namespace API_FullGasPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TanqueController : ControllerBase
    {
        private readonly ITanqueRepository _tanquesRepository;

        public TanqueController(ITanqueRepository tanquesRepository)
        {
            _tanquesRepository = tanquesRepository;
        }

        // GET: api/Tanque
        [HttpGet]
        public IEnumerable<Tanque> Get()
        {
            return _tanquesRepository.ListarTanque();
        }

        // GET: api/Tanque/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tanque
        [HttpPost]
        public IActionResult Post([FromBody] Tanque tanque)
        {
            _tanquesRepository.AgregarTanque(tanque);
            return Ok(tanque);
        }

        // PUT: api/Tanque/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
