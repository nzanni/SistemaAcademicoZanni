using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.AccesoAdatos;
using SistemaAcademicoZanni.Helpers;
using SistemaAcademicoZanni.Models;
using SistemaAcademicoZanni.Servicios;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Carreras
{
    public class EditCarreraModel : PageModel
    {
    
        [BindProperty]
        public Carrera Carrera { get; set; }
        public List<string> Modalidades { get; set; } = new();
        private readonly ServicioCarrera servicio;

        public EditCarreraModel()
        {
            IAccesoDatos<Carrera> acceso = new AccesoDatosJson<Carrera>("Carrera");
            IRepositorio<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
            servicio = new ServicioCarrera(repo);
        }

        public void OnGet(int id)
        {
            Modalidades = OpcionesModalidad.Lista;

            Carrera? carrera = servicio.BuscarPorId(id);
            if (carrera != null)
            {
                Carrera = carrera;
            }
        }
     
public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            servicio.Editar(Carrera);

            return RedirectToPage("IndexCarrera");
        }
    }
    }

