using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FullGas.Core.Interfaces;
using FullGas.Core.Entities;
using FullGas.Core.DTOs;
using FullGas.Core.Interfaces.Services;


namespace API_FullGasPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstacionController : ControllerBase
    {
        private readonly IEstacionServices _estacionServices;

        public EstacionController(IEstacionServices estacionServices)
        {
            _estacionServices = estacionServices;
        }
        // GET: api/Estacion
        [HttpGet]
        public IEnumerable<EstacionDto> Get()
        {
            var estaciones = _estacionServices.ListarEstaciones();
            var lista = new List<EstacionDto>();

            foreach (Estacion item in estaciones)
            {
                lista.Add(new EstacionDto()
                {
                    EstacionId = item.EstacionId,
                    EstacionName = item.EstacionName,
                    EstacionCuil = item.EstacionCuil,
                    EstacionDireccion = item.EstacionDireccion,
                    EstacionTelefono = item.EstacionTelefono
                });
            }
            return lista;
        }

        [HttpGet, ActionName("GetPlayero")]
        [Route("GetPlayero")]
        public IEnumerable<PlayeroDto> GetPlayero()
        {
            var playeros = _estacionServices.ListarPLayero();
            var lista = new List<PlayeroDto>();

            foreach (Playero item in playeros)
            {
                lista.Add(new PlayeroDto()
                {
                    PlayeroId = item.PlayeroId,
                    EstacionId = item.EstacionId,
                    PlayeroName = item.PlayeroName,
                    PlayeroSecondName = item.PlayeroSecondName,
                    PlayeroDni = item.PlayeroDni,
                    PlayeroCuil = item.PlayeroCuil,
                    PlayeroTelefono = item.PlayeroTelefono
                });
            }
            return lista;
        }

        // GET: api/Estacion/5
        [HttpGet("{id}")]
        public EstacionDto GetEstacionId(int id)
        {
            var estacion = _estacionServices.GetEstacionId(id);
            var estacionDto = new EstacionDto()
            {
                EstacionId = estacion.EstacionId,
                EstacionName = estacion.EstacionName,
                EstacionDireccion = estacion.EstacionDireccion,
                EstacionTelefono = estacion.EstacionTelefono,
                EstacionCuil = estacion.EstacionCuil
            };

            return estacionDto;
        }


        // POST: api/Estacion
        [HttpPost]
        public IActionResult Post([FromBody] EstacionDto newEstacion)
        {
            var estacion = new Estacion()
            {
                EstacionId = newEstacion.EstacionId,
                EstacionName = newEstacion.EstacionName,
                EstacionDireccion = newEstacion.EstacionDireccion,
                EstacionTelefono = newEstacion.EstacionTelefono,
                EstacionCuil = newEstacion.EstacionCuil,
            };

            _estacionServices.AgregarEstacion(estacion);
            return Ok(estacion);
        }

        [HttpPost, ActionName("PostPlayero")]
        [Route("PostPlayero")]
        public IActionResult Post([FromBody] PlayeroDto newPlayero)
        {
            var playero = new Playero()
            {
                PlayeroId = newPlayero.PlayeroId,
                PlayeroName = newPlayero.PlayeroName,
                PlayeroSecondName = newPlayero.PlayeroSecondName,
                PlayeroDni = newPlayero.PlayeroDni,
                PlayeroCuil = newPlayero.PlayeroCuil,
                PlayeroTelefono = newPlayero.PlayeroTelefono
            };

            _estacionServices.AgregarPlayero(playero);
            return Ok(playero);
        }


        //PUT: api/Estacion/5
        [HttpPut]
        public IActionResult Put([FromBody] EstacionDto estacionDto)
        {
            var estacion = new Estacion()
            {
                EstacionId = estacionDto.EstacionId,
                EstacionName = estacionDto.EstacionName,
                EstacionDireccion = estacionDto.EstacionDireccion,
                EstacionTelefono = estacionDto.EstacionTelefono,
                EstacionCuil = estacionDto.EstacionCuil
            };

            _estacionServices.Actualizar(estacion);
            return Ok(estacionDto);
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _estacionServices.DeleteEstacion(id);
            return Ok("Borrado Correcto");
        }

    }
}
