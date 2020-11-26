using System;
using System.Collections.Generic;

namespace FullGas.Core.Entities
{
    public partial class TipoCombustible
    {
        public TipoCombustible()
        {
            Operacion = new HashSet<Operacion>();
            Surtidor = new HashSet<Surtidor>();
            Tanque = new HashSet<Tanque>();
        }

        public int TipoCombustibleId { get; set; }
        public string TipoCimbustibleNombre { get; set; }
        public decimal? TipoCombustiblePrecio { get; set; }

        public virtual ICollection<Operacion> Operacion { get; set; }
        public virtual ICollection<Surtidor> Surtidor { get; set; }
        public virtual ICollection<Tanque> Tanque { get; set; }
    }
}
