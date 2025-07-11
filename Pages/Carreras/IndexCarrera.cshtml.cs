using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;

namespace SistemaAcademicoZanni.Pages.Carreras
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Carrera> Carreras { get; set; } = new();

        public void OnGet()
        {
            var carreraUno = new Carrera
            {
                Id = 1,
                Nombre = "Ingeniería en Sistemas",
                Modalidad = "Presencial",
                DuracionAnios = 5,
                TituloOtorgado = "Ingeniero en Sistemas"
            };

            var carreraDos = new Carrera
            {
                Id = 2,
                Nombre = "Analista de Sistemas",
                Modalidad = "Distancia",
                DuracionAnios = 3,
                TituloOtorgado = "Analista de Sistemas"
            };

            Carreras.Add(carreraUno);
            Carreras.Add(carreraDos);
        }
    }
}
