using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public void OnGet(int id)
        {

            Alumno? alumno = ServicioAlumno.BuscarPorId(id);
            if (alumno != null)
            {
                Alumno = alumno;
            }
        }

        public IActionResult OnPost()
        {

            ServicioAlumno.EditarAlumno(Alumno);

            return RedirectToPage("IndexAlumno");
        }
    }
}