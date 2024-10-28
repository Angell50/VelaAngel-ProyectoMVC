using System.ComponentModel.DataAnnotations;

namespace VelaAngel_ProyectoMVC.Models
{
    public class Carrera
    {
        [Required]
        [Range(1,1000)]
        public string Id { get; set; }

        [AllowedValues("Software","Redes")]
        public string Nombre { get; set; }
    }
}
