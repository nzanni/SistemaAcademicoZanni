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


   // public static List<Alumno> listaAlumnos = new List<Alumno>();
    private static int ultimoId = 0;
 public IActionResult OnPost()
        {
            ultimoId++;
            Alumno.Id = ultimoId;
            DatosCompartidos.Alumnos.Add(Alumno);
            return RedirectToPage("IndexAlumno");
        }
    }
}
