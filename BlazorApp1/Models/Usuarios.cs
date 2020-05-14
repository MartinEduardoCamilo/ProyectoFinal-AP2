using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Usuario = string.Empty;
            Contraseña = string.Empty;
            Contraseña = string.Empty;
            FechaIngreso = DateTime.Now;
        }

        public Usuarios(int usuarioId, string nombre, string usuario, string contraseña, DateTime fechaIngreso)
        {
            UsuarioId = usuarioId;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
            Contraseña = contraseña ?? throw new ArgumentNullException(nameof(contraseña));
            FechaIngreso = fechaIngreso;
        }
    }
}
