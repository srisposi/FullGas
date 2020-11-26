using System;
using System.Collections.Generic;

namespace FullGas.Core.Entities
{
    public partial class Tanque
    {
        public Tanque()
        {
            Operacion = new HashSet<Operacion>();
        }

        public int TanqueId { get; set; }
        public int TipoCombustibleId { get; set; }
        public decimal? TanqueCapacidad { get; set; }
        public decimal? TanqueDisponible { get; set; }

        public virtual TipoCombustible TipoCombustible { get; set; }
        public virtual ICollection<Operacion> Operacion { get; set; }
    }
}
