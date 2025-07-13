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

            public static int ObtenerNuevoIdCarrera(List<Carrera> carreras)
            {
                int maxId = 0;

                foreach (var carrera in carreras)
                {
                    if (carrera.Id > maxId)
                    {
                        maxId = carrera.Id;
                    }
                }

                return maxId + 1;
            }

            public static List<Alumno> Alumnos { get; set; } = new List<Alumno>();
            private static int ultimoIdAlumno = 0;
            public static int ObtenerNuevoIdAlumno(List<Alumno> alumnos)
            {
                int maxId = 0;

                foreach (var alumno in alumnos)
                {
                    if (alumno.Id > maxId)
                    {
                        maxId = alumno.Id;
                    }
                }

                return maxId + 1;
            }
        }

    }
}
