using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;
using SistemaAcademicoZanni.Servicios;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Pages.Carreras
{
    public class IndexModel : PageModel
    {
            public List<Carrera> Carreras { get; set; }

        private readonly ServicioCarrera servicio;

        public IndexModel()
        {
            servicio = new ServicioCarrera();
        }


        public void OnGet()
            {
                Carreras = servicio.ObtenerTodos();
            }
        }
    }
