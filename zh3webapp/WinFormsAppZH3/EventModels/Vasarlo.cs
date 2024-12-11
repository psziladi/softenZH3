using System;
using System.Collections.Generic;

namespace WinFormsAppZH3.EventModels
{
    public partial class Vasarlo
    {
        public Vasarlo()
        {
            Jegy = new HashSet<Jegy>();
        }

        public int VasarloId { get; set; }
        public string Nev { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telefon { get; set; }

        public virtual ICollection<Jegy> Jegy { get; set; }
    }
}
