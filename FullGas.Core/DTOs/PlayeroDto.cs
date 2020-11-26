using System;
using System.Collections.Generic;

namespace FullGas.Core.DTOs
{
    public partial class PlayeroDto
    {
        public int PlayeroId { get; set; }
        public int EstacionId { get; set; }
        public string PlayeroName { get; set; }
        public string PlayeroSecondName { get; set; }
        public string PlayeroDni { get; set; }
        public string PlayeroCuil { get; set; }
        public string PlayeroTelefono { get; set; }
    }
}
