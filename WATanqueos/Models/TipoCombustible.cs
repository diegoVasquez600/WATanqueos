using System;
using System.Collections.Generic;

#nullable disable

namespace WATanqueos.Models
{
    public partial class TipoCombustible
    {
        public TipoCombustible()
        {
            Islas = new HashSet<Isla>();
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdTipoCombustible { get; set; }
        public string TipoCombustible1 { get; set; }

        public virtual ICollection<Isla> Islas { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
