using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;
using System.Collections.Generic;

namespace SistemaAcademicoZanni.Pages.Carreras
{
    public class CreateCarreraModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        public void OnGet()
        {
        }

        public static List<Carrera> listaCarreras = new List<Carrera>();
        private static int ultimoId = 0;

        public void OnPost()
        {
            ultimoId++;
            Carrera.Id = ultimoId;
            listaCarreras.Add(Carrera);
        }


    }
}
