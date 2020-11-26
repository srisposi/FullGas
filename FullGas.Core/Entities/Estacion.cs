using System;
using System.Collections.Generic;


namespace FullGas.Core.Entities
{
    public partial class Estacion
    {
        public Estacion()
        {
            Playero = new HashSet<Playero>();
        }

        public int EstacionId { get; set; }
        public string EstacionName { get; set; }
        public string EstacionDireccion { get; set; }
        public string EstacionTelefono { get; set; }
        public string EstacionCuil { get; set; }

        public virtual ICollection<Playero> Playero { get; set; }
    }
}
