using FullGas.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullGas.Core.Interfaces
{
    public interface ITanqueRepository
    {
        #region Todo lo relacionado con Tanque
        void AgregarTanque(Tanque tanque);
        void ActualizarTanque(Tanque tanque);
        IEnumerable<Tanque> ListarTanque();
        #endregion

        #region Todo lo relacionado con Tipo de Combustible
        void AgregarTipoCombustible(TipoCombustible tipoCombustible);
        void ActualizarTipoCombustible(TipoCombustible tipoCombustible);
        IEnumerable<TipoCombustible> ListarTipoCombustible();
        #endregion
    }
}
