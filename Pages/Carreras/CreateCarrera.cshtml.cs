using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;
using System.Collections.Generic;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Carreras
{
    public class CreateCarreraModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public Carrera Carrera { get; set; }

        public static List<Carrera> listaCarreras = new List<Carrera>();
        private static int ultimoId = 0;

        public IActionResult OnPost()
        {
            ultimoId++;
            Carrera.Id = ultimoId;
            DatosCompartidos.Carreras.Add(Carrera);
            return RedirectToPage("IndexCarrera");
        }


    }
}
