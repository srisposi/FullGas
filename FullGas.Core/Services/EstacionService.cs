using System;
using System.Collections.Generic;
using System.Text;
using FullGas.Core.Entities;
using FullGas.Core.Interfaces.Services;
using FullGas.Core.Interfaces;

namespace FullGas.Core.Services
{
    
    //Vamos a consumir los servicios
    public class EstacionService : IEstacionServices
    {
        //Inyectamos la dependencia del repositorio
        private readonly IEstacionRepository _estacionRepository;
        public EstacionService(IEstacionRepository estacionRepository)
        {
            _estacionRepository = estacionRepository;
        }


        #region Todo lo relacionado con Estación
        public IEnumerable<Estacion> ListarEstaciones()
        {
            return _estacionRepository.ListarEstaciones();
        }
        public Estacion GetEstacionId(int id)
        {
            return _estacionRepository.GetEstacionId(id);
        }
        public void Actualizar(Estacion estacion)
        {
            _estacionRepository.Actualizar(estacion);
        }

        public void AgregarEstacion(Estacion estacion)
        {
            //Lógica de negocio
            _estacionRepository.AgregarEstacion(estacion);           
        }
        public void DeleteEstacion(int id)
        {
            _estacionRepository.DeleteEstacion(id);
        }
        #endregion

        #region Todo lo relacionado con Playero
        public IEnumerable<Playero> ListarPLayero()
        {
            return _estacionRepository.ListarPLayero();
        }
        public void AgregarPlayero(Playero playero)
        {
            _estacionRepository.AgregarPlayero(playero);
        }
        public void ActualizarPlayero(Playero playero)
        {
            _estacionRepository.ActualizarPlayero(playero);
        }
        public void DeletePlayero(Playero playero)
        {
            _estacionRepository.DeletePlayero(playero);
        }
        #endregion
    }


    //{
    //    //Inyección de DBContext
    //    private readonly FullGasContext _fullGasContext;

    //    public EstacionService(FullGasContext fullGasContext)
    //    {
    //        _fullGasContext = fullGasContext;
    //    }


    //}
}
