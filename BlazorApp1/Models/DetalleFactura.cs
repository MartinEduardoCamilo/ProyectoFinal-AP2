using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class DetalleFactura
    {
        [Key]
        public int DetalleFacturaId { get; set; }
        public int FacturaId { get; set; }
        public int ArticulosId { get; set; }
        public int Tamaño { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public DetalleFactura()
        {

        }

        public DetalleFactura(int detalleFacturaId, int facturaId, int articulosId, int tamaño, int cantidad, decimal precio, decimal importe)
        {
            DetalleFacturaId = detalleFacturaId;
            FacturaId = facturaId;
            ArticulosId = articulosId;
            Tamaño = tamaño;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
