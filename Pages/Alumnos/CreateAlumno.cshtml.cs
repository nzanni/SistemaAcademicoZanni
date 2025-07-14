using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Data;
using SistemaAcademicoZanni.Models;
using SistemaAcademicoZanni.Servicios;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Alumnos
{
    public class CreateAlumnoModel : PageModel
    {
        [BindProperty]
        public Alumno Alumno { get; set; }

        private readonly ServicioAlumno servicio;

        public CreateAlumnoModel()
        {
            servicio = new ServicioAlumno();
        }



        public void OnGet()
        {
        }

 public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            servicio.Agregar(Alumno);
            return RedirectToPage("IndexAlumno");
        }
    }
}
