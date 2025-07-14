using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.AccesoAdatos;
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
            IAccesoDatos<Carrera> acceso = new AccesoDatosJson<Carrera>("Carrera");
            IRepositorio<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
            servicio = new ServicioCarrera(repo);
        }


        public void OnGet()
            {
                Carreras = servicio.ObtenerTodos();
            }
        }
    }
