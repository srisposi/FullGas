using System;
using System.Collections.Generic;

namespace FullGas.Core.Entities
{
    public partial class Surtidor
    {
        public Surtidor()
        {
            Operacion = new HashSet<Operacion>();
        }

        public int SurtidorId { get; set; }
        public int TipoCombustibleId { get; set; }
        public string SurtidorName { get; set; }

        public virtual TipoCombustible TipoCombustible { get; set; }
        public virtual ICollection<Operacion> Operacion { get; set; }
    }
}
