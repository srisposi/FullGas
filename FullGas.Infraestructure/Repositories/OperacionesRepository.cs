using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FullGas.Core.Entities;
using FullGas.Core.Interfaces;
using FullGas.Infraestructure.Data;
namespace FullGas.Infraestructure.Repositories
{
    public class OperacionesRepository : IOperacionesRepository
    {
        //Patrón de Inyección de Dependencia por Constructor
        private readonly FullGasContext _fullGasContext;
        public OperacionesRepository(FullGasContext fullGasContext)
        {
            _fullGasContext = fullGasContext;
        }

        #region Todo lo relacionado con Operaciones
        public void ActualizarOperacion(Operacion operacion)
        {
            throw new NotImplementedException();
        }
        public void AgregarOperacion(Operacion operacion)
        {
            _fullGasContext.Operacion.Add(operacion);
            _fullGasContext.SaveChanges();
        }
        public IEnumerable<Operacion> ListarOperaciones()
        {
            var operaciones = _fullGasContext.Operacion.ToList();
            return operaciones;
        }
        #endregion

        #region Todo lo relacionado con Surtidor
        public void ActualizarSurtidor(Surtidor surtidor)
        {
            throw new NotImplementedException();
        }
        public void AgregarSurtidor(Surtidor surtidor)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Surtidor> ListarSurtidor()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
