using System.ComponentModel.DataAnnotations;

namespace SistemaAcademicoZanni.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string Apellido { get; set; }
        [Range(1000000, 99999999, ErrorMessage = "El DNI debe tener entre 7 y 8 dígitos.")]
        public int? DNI { get; set; }
        [Required(ErrorMessage = "El email es obligatorio.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateTime FechaDeNacimiento { get; set; }
    }
}
