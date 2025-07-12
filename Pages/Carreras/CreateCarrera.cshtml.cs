using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Helpers;
using SistemaAcademicoZanni.Models;
using System.Collections.Generic;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Carreras
{
    public class CreateCarreraModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        public List<string> Modalidades { get; set; } = new();

        public void OnGet()
        {
            Modalidades = OpcionesModalidad.Lista;
        }

        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            Carrera.Id = DatosCompartidos.ObtenerNuevoIdCarrera();

            DatosCompartidos.Carreras.Add(Carrera);
            return RedirectToPage("IndexCarrera");
        }


    }
}
