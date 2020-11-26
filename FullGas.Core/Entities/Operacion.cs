using System;
using System.Collections.Generic;

namespace FullGas.Core.Entities
{
    public partial class Operacion
    {
        public int OperacionId { get; set; }
        public int TanqueId { get; set; }
        public int PlayeroId { get; set; }
        public int SurtidorId { get; set; }
        public decimal? OperacionCantidadLitro { get; set; }
        public decimal? OperacionTotal { get; set; }
        public int? TipoCombustibleId { get; set; }

        public virtual Playero Playero { get; set; }
        public virtual Surtidor Surtidor { get; set; }
        public virtual Tanque Tanque { get; set; }
        public virtual TipoCombustible TipoCombustible { get; set; }
    }
}
