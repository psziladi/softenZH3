using System;
using System.Collections.Generic;

namespace WinFormsAppZH3.EventModels
{
    public partial class Jegy
    {
        public int JegyId { get; set; }
        public int RendezvenyId { get; set; }
        public int VasarloId { get; set; }
        public DateTime VasarlasIdopont { get; set; }
        public decimal Ar { get; set; }

        public virtual Rendezveny Rendezveny { get; set; } = null!;
        public virtual Vasarlo Vasarlo { get; set; } = null!;
    }
}
