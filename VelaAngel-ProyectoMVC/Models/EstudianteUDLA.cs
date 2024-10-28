using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace VelaAngel_ProyectoMVC.Models
{
    public class EstudianteUDLA
    {
        [Required]
        public string IDBanner { get; set; }

        [AllowNull]
        public string Correo { get; set; }

        [MaxLength(100)]
        public string Nombre { get; set; }
        public Carrera Carrera { get; set; }
    }
      
}
