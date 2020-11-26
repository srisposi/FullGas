using System;
using System.Collections.Generic;
using System.Text;
using FullGas.Core.Entities;
using FullGas.Core.Interfaces.Services;

namespace FullGas.Core.Interfaces.Services
{
    public interface IEstacionServices   {
        #region Todo lo realcionado con la Estacion
        IEnumerable<Estacion> ListarEstaciones();
        Estacion GetEstacionId(int id);
        void Actualizar(Estacion estacion);
        void AgregarEstacion(Estacion estacion);
        void DeleteEstacion(int id);
        #endregion


        #region Todo lo relacionado con el Playero
        IEnumerable<Playero> ListarPLayero();
        void ActualizarPlayero(Playero playero);
        void AgregarPlayero(Playero playero);
        void DeletePlayero(Playero playero);
        #endregion


    }
}
