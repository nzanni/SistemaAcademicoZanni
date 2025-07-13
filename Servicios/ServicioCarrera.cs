using SistemaAcademicoZanni.Models;
using System.Text.Json;

namespace SistemaAcademicoZanni.Servicios
{
    public static class ServicioCarrera
    {
        private static string ruta = "Data/carreras.json";

        public static string LeerTextoDelArchivo()
        {
            if (File.Exists(ruta))
            {
                return File.ReadAllText(ruta);
            }

            return "[]";
        }
        public static List<Carrera> ObtenerCarreras()
        {
            string json = LeerTextoDelArchivo();
            var lista = JsonSerializer.Deserialize<List<Carrera>>(json);
            return lista ?? new List<Carrera>();
        }
    }
}
