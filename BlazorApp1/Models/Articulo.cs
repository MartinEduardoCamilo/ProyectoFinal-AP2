using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Articulo
    {
        [Key]
        public int ArticulosId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Articulo()
        {
            ArticulosId = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
        }

        public Articulo(int articulosId, string descripcion, int cantidad)
        {
            ArticulosId = articulosId;
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            Cantidad = cantidad;
        }

    }
}
