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
            private static int ultimoIdCarrera = 0;
            public static int ObtenerNuevoIdCarrera()
            {
                ultimoIdCarrera++;
                return ultimoIdCarrera;
            }
            public static List<Alumno> Alumnos { get; set; } = new List<Alumno>();
            private static int ultimoIdAlumno = 0;
            public static int ObtenerNuevoIdAlumno()
            {
                ultimoIdAlumno++;
                return ultimoIdAlumno;
            }
        }

    }
}
