using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FullGas.Core.Entities;
using FullGas.Core.Interfaces;
using FullGas.Infraestructure.Data;

namespace FullGas.Infraestructure.Repositories
{
    public class TanqueRepository : ITanqueRepository
    {
        private readonly FullGasContext _fullGasContext;

        public TanqueRepository(FullGasContext fullGasContext)
        {
            _fullGasContext = fullGasContext;
        }

        #region Todo lo relacionado con Tanque
        public void ActualizarTanque(Tanque tanque)
        {
            throw new NotImplementedException();
        }
        public void AgregarTanque(Tanque tanque)
        {
            _fullGasContext.Tanque.Add(tanque);
            _fullGasContext.SaveChanges();
        }
        public IEnumerable<Tanque> ListarTanque()
        {
            var tanques = _fullGasContext.Tanque.ToList();
            return tanques;
        }
        #endregion

        #region Todo lo relacionado con Tipo Combustible
        public void AgregarTipoCombustible(TipoCombustible tipoCombustible)
        {
            throw new NotImplementedException();
        }
        public void ActualizarTipoCombustible(TipoCombustible tipoCombustible)
        {
            throw new NotImplementedException();
        }     
        public IEnumerable<TipoCombustible> ListarTipoCombustible()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
