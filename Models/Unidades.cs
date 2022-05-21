using System.ComponentModel.DataAnnotations;

namespace Bootcamp_MVC_2_NUEVO.Models
{
    public class Unidades
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La Marca es obligatoria")] //requerido
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1}", MinimumLength = 3)] //longitud
        [Display(Name = "Marca")] // como se va a mostrar
        public string Marca { get; set; }

        [Required(ErrorMessage = "El Modelo es obligatorio")] //requerido
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1}", MinimumLength = 3)] //longitud
        [Display(Name = "Modelo")] // como se va a mostrar
        public string Modelo { get; set; }

        [Required(ErrorMessage = "El año es obligatorio")] //requerido
        [DataType(DataType.Date)]
        [Display(Name = "Año")] // como se va a mostrar
        public DateTime Ano { get; set; }

        [Required(ErrorMessage = "El kilometraje es obligatorio")] //requerido
        [Display(Name = "Kilometraje")] // como se va a mostrar
        public int Kilometro { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")] //requerido
        [Display(Name = "Precio")] // como se va a mostrar
        public double Precio { get; set; }

    }
}
