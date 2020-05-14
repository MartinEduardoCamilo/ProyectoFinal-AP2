using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public decimal Consumo { get; set; }



        public Clientes()
        {
            ClienteId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            Direccion = string.Empty;
            Consumo = 0;

        }

        public Clientes(int clienteId, string nombre, string apellido, string cedula, string telefono, string email, string direccion, decimal consumo)
        {
            ClienteId = clienteId;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            Cedula = cedula ?? throw new ArgumentNullException(nameof(cedula));
            Telefono = telefono ?? throw new ArgumentNullException(nameof(telefono));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            Consumo = consumo;
        }
    }
}
