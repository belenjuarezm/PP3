using System;
using System.Collections.Generic;

namespace Tpcarrito.models
{
    public partial class Ventum
    {
        public Ventum()
        {
            DetalleVenta = new HashSet<DetalleVentum>();
        }

        public int IdVenta { get; set; }
        public int? IdCliente { get; set; }
        public int? TotalProducto { get; set; }
        public decimal? MontoTotal { get; set; }
        public DateTime? FechaVenta { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; }
    }
}
