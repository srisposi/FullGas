using System;
using System.Collections.Generic;

namespace FullGas.Core.Entities
{
    public partial class Playero
    {
        public Playero()
        {
            Operacion = new HashSet<Operacion>();
        }

        public int PlayeroId { get; set; }
        public int EstacionId { get; set; }
        public string PlayeroName { get; set; }
        public string PlayeroSecondName { get; set; }
        public string PlayeroDni { get; set; }
        public string PlayeroCuil { get; set; }
        public string PlayeroTelefono { get; set; }

        public virtual Estacion Estacion { get; set; }
        public virtual ICollection<Operacion> Operacion { get; set; }
    }
}
