using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;

namespace SistemaAcademicoZanni.Pages.Alumnos
{
    public class CreateAlumnoModel : PageModel
{
    [BindProperty]
    public Alumno Alumno { get; set; }
    public void OnGet()
    {
    }

    public static List<Alumno> listaAlumnos = new List<Alumno>();
    private static int ultimoId = 0;

    public void OnPost()
    {
        ultimoId++;
        Alumno.Id = ultimoId;
        listaAlumnos.Add(Alumno);
    }


    }
}
