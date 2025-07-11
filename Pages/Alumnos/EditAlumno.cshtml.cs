using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;
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

            if (!ModelState.IsValid)
            {
                return Page();
            }


            foreach (var a in DatosCompartidos.Alumnos)
            {
                if (a.Id == Alumno.Id)
                {
                    a.Nombre = Alumno.Nombre;
                    a.Apellido = Alumno.Apellido;
                    a.DNI= Alumno.DNI;
                    a.Email = Alumno.Email;
                    a.FechaDeNacimiento = Alumno.FechaDeNacimiento;
                    break;
                }
            }
            return RedirectToPage("IndexAlumno");
        }
    }
}