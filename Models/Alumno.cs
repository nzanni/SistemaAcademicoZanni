namespace SistemaAcademicoZanni.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public int DNI { get; set; }

        public string? Email { get; set; }

        public DateTime FechaDeNacimiento { get; set; }
    }
}
