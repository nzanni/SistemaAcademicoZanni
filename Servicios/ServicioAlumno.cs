using SistemaAcademicoZanni.Models;
using System.Text.Json;

namespace SistemaAcademicoZanni.Servicios
{
    public class ServicioAlumno
    {
        private static string ruta = "Data/alumnos.json";

        public static string LeerTextoDelArchivo()
        {
            if (File.Exists(ruta))
            {
                return File.ReadAllText(ruta);
            }

            return "[]";
        }
        public static List<Alumno> ObtenerAlumnos()
        {
            string json = LeerTextoDelArchivo();
            var lista = JsonSerializer.Deserialize<List<Alumno>>(json);
            return lista ?? new List<Alumno>();
        }
    }
}