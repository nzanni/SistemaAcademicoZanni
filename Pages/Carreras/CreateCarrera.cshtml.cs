using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.AccesoAdatos;
using SistemaAcademicoZanni.Helpers;
using SistemaAcademicoZanni.Models;
using SistemaAcademicoZanni.Servicios;
using System.Collections.Generic;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Carreras
{
    public class CreateCarreraModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        public List<string> Modalidades { get; set; } = new();
        private readonly ServicioCarrera servicio;

        public CreateCarreraModel()
        {
            IAccesoDatos<Carrera> acceso = new AccesoDatosJson<Carrera>("Carrera");
            IRepositorio<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
            servicio = new ServicioCarrera(repo);


        }


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


            servicio.Agregar(Carrera);
            return RedirectToPage("IndexCarrera");
        }


    }
}
