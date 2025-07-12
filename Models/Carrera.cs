using System.ComponentModel.DataAnnotations;

namespace SistemaAcademicoZanni.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre de la carrera es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La duración es obligatoria.")]
        public int? DuracionAnios { get; set; }
        [Required(ErrorMessage = "El título otorgado es obligatorio.")]
        public string TituloOtorgado { get; set; }
        [Required(ErrorMessage = "La modalidad es obligatoria.")]
        public string Modalidad { get; set; }
    }
}
