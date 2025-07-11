using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Data;
using SistemaAcademicoZanni.Models;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Alumnos
{
    public class CreateAlumnoModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
    public Alumno Alumno { get; set; }

 public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Alumno.Id = DatosCompartidos.ObtenerNuevoIdAlumno();
            DatosCompartidos.Alumnos.Add(Alumno);
            return RedirectToPage("IndexAlumno");
        }
    }
}
