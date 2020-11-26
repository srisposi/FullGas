using System;
using System.Collections.Generic;
using System.Text;
using FullGas.Core.Entities;

namespace FullGas.Core.Interfaces
{
    public interface IEstacionRepository
    {
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
