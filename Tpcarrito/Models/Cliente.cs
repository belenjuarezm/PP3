using System;
using System.Collections.Generic;

namespace Tpcarrito.models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Carritos = new HashSet<Carrito>();
            Venta = new HashSet<Ventum>();
        }

        public int IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion { get; set; }
        public string? Celular { get; set; }

        public virtual ICollection<Carrito> Carritos { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
