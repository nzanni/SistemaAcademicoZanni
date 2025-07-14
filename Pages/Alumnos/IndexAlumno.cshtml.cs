using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.AccesoAdatos;
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
            IAccesoDatos<Alumno> acceso = new AccesoDatosJson<Alumno>("Alumno");
            IRepositorio<Alumno> repo = new RepositorioCrudJson<Alumno>(acceso);
            servicio = new ServicioAlumno(repo);
        }
        public void OnGet()
            {
            Alumnos = servicio.ObtenerTodos();
        }
        }
    }

