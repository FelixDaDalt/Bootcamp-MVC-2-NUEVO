using System.ComponentModel.DataAnnotations;

namespace Bootcamp_MVC_2_NUEVO.Models
{
    public class Home
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo es obligatorio")] //requerido
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1}", MinimumLength = 3)] //longitud
        [Display(Name = "Título")] // como se va a mostrar
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Descripción es obligatoria")] //requerido
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1}", MinimumLength = 3)] //longitud
        [Display(Name = "Descripción")] // como se va a mostrar
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Logo es obligatorio")] //requerido
        public string Logo { get; set; }
    }
}
