using FullGas.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace FullGas.Core.Interfaces
{
    public interface IOperacionesRepository
    {
        #region Todo lo relacionado con Operaciones
        void AgregarOperacion (Operacion operacion);
        void ActualizarOperacion(Operacion operacion);
        IEnumerable<Operacion> ListarOperaciones();
        #endregion


        #region Todo lo relacionado con Surtidor
        void AgregarSurtidor(Surtidor surtidor);
        void ActualizarSurtidor(Surtidor surtidor);
        IEnumerable<Surtidor>ListarSurtidor();
        #endregion
    }
}
