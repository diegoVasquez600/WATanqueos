using System;
using System.Collections.Generic;

#nullable disable

namespace WATanqueos.Models
{
    public partial class Tanqueo
    {
        public int IdTanqueo { get; set; }
        public int IdVehiculo { get; set; }
        public int IdIsla { get; set; }
        public string Placa { get; set; }
        public int? Valor { get; set; }

        public virtual Isla IdIslaNavigation { get; set; }
        public virtual Vehiculo IdVehiculoNavigation { get; set; }
    }
}
