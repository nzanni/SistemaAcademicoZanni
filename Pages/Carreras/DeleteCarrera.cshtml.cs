using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;
using SistemaAcademicoZanni.Servicios;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Carreras
{
    public class DeleteCarreraModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }

        public IActionResult OnGet(int id)
        {

            var carrera = ServicioCarrera.BuscarPorId(id);
            if (carrera == null)
            {
                return RedirectToPage("IndexCarrera");
            }

            Carrera = carrera;
            return Page();
        }
public IActionResult OnPost(int id)
        {
            ServicioCarrera.EliminarPorId(id);
            return RedirectToPage("IndexCarrera");

        }
    }
}
