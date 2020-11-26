using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FullGas.Core.Entities;
using FullGas.Core.Interfaces;
using FullGas.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FullGas.Infraestructure.Repositories
{
    public class EstacionRepository : IEstacionRepository
    {
        private readonly FullGasContext _fullGasContext;

        public EstacionRepository(FullGasContext fullGasContext)
        {
            _fullGasContext = fullGasContext;
        }



        #region Todo lo relacionado con Estación

        public IEnumerable<Estacion> ListarEstaciones()
        {
            var estaciones = _fullGasContext.Estacion.ToList();
            return estaciones;
         
        }
        public Estacion GetEstacionId(int id)
        {
            var estacion = _fullGasContext.Estacion.FirstOrDefault(p => p.EstacionId == id);
            return estacion;
        }
        public void Actualizar(Estacion estacion)
        {
            var estacionEdit = _fullGasContext.Estacion.FirstOrDefault(p => p.EstacionId == estacion.EstacionId);
            estacionEdit.EstacionName = estacion.EstacionName;
            estacionEdit.EstacionDireccion = estacion.EstacionDireccion;
            estacionEdit.EstacionCuil = estacion.EstacionCuil;
            estacionEdit.EstacionTelefono = estacion.EstacionTelefono;
            _fullGasContext.Entry(estacionEdit).State = EntityState.Modified;
            _fullGasContext.SaveChanges();

        }
        public void AgregarEstacion(Estacion estacion)
        {
            _fullGasContext.Estacion.Add(estacion);
            _fullGasContext.SaveChanges();

        }

        public void DeleteEstacion(int id)
        {

            var estacionDelete = _fullGasContext.Estacion.Find(id);
            _fullGasContext.Estacion.Remove(estacionDelete);
            _fullGasContext.SaveChanges();
        }
        #endregion


        #region Todo lo relacionado con Playero
        public IEnumerable<Playero> ListarPLayero()
        {
            var playeros = _fullGasContext.Playero.ToList();
            return playeros;
        }
        public void ActualizarPlayero(Playero playero)
        {
            _fullGasContext.Playero.Add(playero);
            _fullGasContext.SaveChanges();
        }
        public void AgregarPlayero(Playero playero)
        {
            _fullGasContext.Entry(playero).State = EntityState.Modified;
            _fullGasContext.SaveChanges();
        }
        public void DeletePlayero(Playero playero)
        {
            _fullGasContext.Playero.Remove(playero);
            _fullGasContext.SaveChanges();
        }
        #endregion

    }
}
