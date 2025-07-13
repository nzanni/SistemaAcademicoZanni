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

            public void OnGet()
            {
            var RepoAlumno = new RepositorioCrudJson<Alumno>("alumnos");
            Alumnos = RepoAlumno.ObtenerTodos();
        }
        }
    }

