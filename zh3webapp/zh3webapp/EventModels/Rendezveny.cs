using System;
using System.Collections.Generic;

namespace zh3webapp.EventModels
{
    public partial class Rendezveny
    {
        public Rendezveny()
        {
            Jegy = new HashSet<Jegy>();
        }

        public int RendezvenyId { get; set; }
        public string Nev { get; set; } = null!;
        public DateTime KezdetiIdo { get; set; }
        public DateTime VegsoIdo { get; set; }
        public string Helyszin { get; set; } = null!;
        public decimal? Koltsegvetes { get; set; }

        public virtual ICollection<Jegy> Jegy { get; set; }
    }
}
