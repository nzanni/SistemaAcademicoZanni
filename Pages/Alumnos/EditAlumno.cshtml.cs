using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.AccesoAdatos;
using SistemaAcademicoZanni.Helpers;
using SistemaAcademicoZanni.Models;
using SistemaAcademicoZanni.Servicios;
using System.ComponentModel.DataAnnotations;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Alumnos
{
    public class EditAlumnoModel : PageModel
    {

        [BindProperty]
        public Alumno Alumno { get; set; }

        private readonly ServicioAlumno servicio;

        public EditAlumnoModel()
        {
            IAccesoDatos<Alumno> acceso = new AccesoDatosJson<Alumno>("Alumno");
            IRepositorio<Alumno> repo = new RepositorioCrudJson<Alumno>(acceso);
            servicio = new ServicioAlumno(repo);
        }

        public void OnGet(int id)
        {

            Alumno? alumno = servicio.BuscarPorId(id);
            if (alumno != null)
            {
                Alumno = alumno;
            }
        }

        public IActionResult OnPost()
        {

            servicio.Editar(Alumno);

            return RedirectToPage("IndexAlumno");
        }
    }
}