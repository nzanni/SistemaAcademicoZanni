using SistemaAcademicoZanni.Models;
using System.Text.Json;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

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
        public static void GuardarAlumnos(List<Alumno> alumnos)
        {
            string textoJson = JsonSerializer.Serialize(alumnos);
            File.WriteAllText("Data/alumnos.json", textoJson);
        }
public static void AgregarAlumno(Alumno nuevoAlumno)
        {
            var alumnos = ObtenerAlumnos();
            nuevoAlumno.Id = DatosCompartidos.ObtenerNuevoIdAlumno(alumnos);
            alumnos.Add(nuevoAlumno);
            GuardarAlumnos(alumnos);
        }

        public static Alumno? BuscarPorId(int id)
        {
            var lista = ObtenerAlumnos();
            foreach (var alumno in lista)
            {
                if (alumno.Id == id)
                {
                    return alumno;
                }
            }
            return null;
        }
        public static void EliminarPorId(int id)
        {
            var lista = ObtenerAlumnos();
            Alumno? alumnoAEliminar = null;

            foreach (var alumno in lista)
            {
                if (alumno.Id == id)
                {
                    alumnoAEliminar = alumno;
                    break;
                }
            }

            if (alumnoAEliminar != null)
            {
                lista.Remove(alumnoAEliminar);
                GuardarAlumnos(lista);
            }
        }
    }
}