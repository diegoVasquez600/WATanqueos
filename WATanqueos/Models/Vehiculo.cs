using System;
using System.Collections.Generic;

#nullable disable

namespace WATanqueos.Models
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Tanqueos = new HashSet<Tanqueo>();
        }

        public int IdVehiculo { get; set; }
        public int IdTipoCombustible { get; set; }
        public string Placa { get; set; }

        public virtual TipoCombustible IdTipoCombustibleNavigation { get; set; }
        public virtual ICollection<Tanqueo> Tanqueos { get; set; }
    }
}
