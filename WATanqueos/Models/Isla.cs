using System;
using System.Collections.Generic;

#nullable disable

namespace WATanqueos.Models
{
    public partial class Isla
    {
        public Isla()
        {
            Tanqueos = new HashSet<Tanqueo>();
        }

        public int IdIsla { get; set; }
        public int IdTipoCombustible { get; set; }
        public string NIsla { get; set; }

        public virtual TipoCombustible IdTipoCombustibleNavigation { get; set; }
        public virtual ICollection<Tanqueo> Tanqueos { get; set; }
    }
}
