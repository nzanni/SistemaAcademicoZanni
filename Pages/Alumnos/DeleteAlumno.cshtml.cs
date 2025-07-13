using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;
using SistemaAcademicoZanni.Servicios;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Alumnos
{
    public class DeleteAlumnoModel : PageModel
    {
        [BindProperty]
        public Alumno Alumno { get; set; }

        public IActionResult OnGet(int id)
        {

            var alumno = ServicioAlumno.BuscarPorId(id);
            if (alumno == null)
            {
                return RedirectToPage("IndexAlumno");
            }

            Alumno = alumno;
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            ServicioAlumno.EliminarPorId(id);
            return RedirectToPage("IndexAlumno");

        }
    }
}
