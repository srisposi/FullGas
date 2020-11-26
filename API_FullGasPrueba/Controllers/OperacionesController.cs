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
    public class OperacionesController : ControllerBase
    {
        private readonly IOperacionesRepository _operacionesRepository;

        public OperacionesController(IOperacionesRepository operacionesRepository)
        {
            _operacionesRepository = operacionesRepository;
        }

        // GET: api/Operaciones
        [HttpGet]
        public IEnumerable<Operacion> Get()
        {
            return _operacionesRepository.ListarOperaciones();
        }

        // GET: api/Operaciones/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Operaciones
        [HttpPost]
        public IActionResult Post([FromBody] Operacion operacion )
        {
            _operacionesRepository.AgregarOperacion(operacion);
            return Ok(operacion);
        }

        // PUT: api/Operaciones/5
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
