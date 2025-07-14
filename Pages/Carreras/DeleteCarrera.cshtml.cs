using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.AccesoAdatos;
using SistemaAcademicoZanni.Models;
using SistemaAcademicoZanni.Servicios;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Carreras
{
    public class DeleteCarreraModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        private readonly ServicioCarrera servicio;


        public DeleteCarreraModel()
        {
            IAccesoDatos<Carrera> acceso = new AccesoDatosJson<Carrera>("Carrera");
            IRepositorio<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
            servicio = new ServicioCarrera(repo);
        }

        public IActionResult OnGet(int id)
        {

            var carrera = servicio.BuscarPorId(id);
            if (carrera == null)
            {
                return RedirectToPage("IndexCarrera");
            }

            Carrera = carrera;
            return Page();
        }
public IActionResult OnPost(int id)
        {
            servicio.EliminarPorId(id);
            return RedirectToPage("IndexCarrera");

        }
    }
}
