using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;
using SistemaAcademicoZanni.Servicios;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Alumnos
{
        public class IndexModel : PageModel
        {
            public List<Alumno> Alumnos { get; set; }


        private readonly ServicioAlumno servicio;

        public IndexModel()
        {
            servicio = new ServicioAlumno();
        }
        public void OnGet()
            {
            Alumnos = servicio.ObtenerTodos();
        }
        }
    }

