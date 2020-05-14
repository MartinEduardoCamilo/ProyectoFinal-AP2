using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public int EventoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public virtual List<DetalleFactura> Detalles { get; set; }

        public Facturas()
        {
            FacturaId = 0;
            ClienteId = 0;
            EventoId = 0;
            Fecha = DateTime.Now;
            Total = 0;
            Detalles = new List<DetalleFactura>();
        }

        public Facturas(int facturaId, int clienteId, int eventoId, DateTime fecha, decimal total, List<DetalleFactura> detalles)
        {
            FacturaId = facturaId;
            ClienteId = clienteId;
            EventoId = eventoId;
            Fecha = fecha;
            Total = total;
            Detalles = detalles ?? throw new ArgumentNullException(nameof(detalles));
        }
    }
}
