using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Alumnos
{
    public class DeleteAlumnoModel : PageModel
    {
        [BindProperty]
        public Alumno Alumno { get; set; }

        public void OnGet(int id)
        {

            foreach (var c in DatosCompartidos.Alumnos)
            {
                if (c.Id == id)
                {
                    Alumno = c;
                    break;
                }
            }
        }
        public IActionResult OnPost()
        {
            Alumno alumnoAEliminar = null;

            foreach (var c in DatosCompartidos.Alumnos)
            {
                if (c.Id == Alumno.Id)
                {
                    alumnoAEliminar = c;
                    break;
                }
            }

            if (alumnoAEliminar != null)
            {
                DatosCompartidos.Alumnos.Remove(alumnoAEliminar);
            }

            return RedirectToPage("IndexAlumno");
        }

    }
}
