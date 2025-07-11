using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;

namespace SistemaAcademicoZanni.Data
{
    public class DatosCompartidosModel : PageModel
    {
        public void OnGet()
        {
        }
   
    public class DatosCompartidos
    {
        public static List<Carrera> Carreras { get; set; } = new List<Carrera>();
        public static List<Alumno> Alumnos { get; set; } = new List<Alumno>();
    }

    }
}
