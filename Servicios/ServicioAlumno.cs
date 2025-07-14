using SistemaAcademicoZanni.Models;
using System.Text.Json;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;

namespace SistemaAcademicoZanni.Servicios
{
    public class ServicioAlumno
    {

        private readonly RepositorioCrudJson<Alumno> crud;
        public ServicioAlumno()
        {
            crud = new RepositorioCrudJson<Alumno>("alumnos");
        }
        public List<Alumno> ObtenerTodos()
        {
            return crud.ObtenerTodos();
        }

        public void Agregar(Alumno alumno)
        {
            crud.Agregar(alumno);
        }

        public Alumno? BuscarPorId(int id)
        {
            return crud.BuscarPorId(id);
        }

        public void Editar(Alumno alumno)
        {
            crud.Editar(alumno);
        }

        public void EliminarPorId(int id)
        {
            crud.EliminarPorId(id);
        }

    }





    //        private static string ruta = "Data/alumnos.json";

    //        public static string LeerTextoDelArchivo()
    //        {
    //            if (File.Exists(ruta))
    //            {
    //                return File.ReadAllText(ruta);
    //            }

    //            return "[]";
    //        }
    //        public static List<Alumno> ObtenerAlumnos()
    //        {
    //            string json = LeerTextoDelArchivo();
    //            var lista = JsonSerializer.Deserialize<List<Alumno>>(json);
    //            return lista ?? new List<Alumno>();
    //        }
    //        public static void GuardarAlumnos(List<Alumno> alumnos)
    //        {
    //            string textoJson = JsonSerializer.Serialize(alumnos);
    //            File.WriteAllText("Data/alumnos.json", textoJson);
    //        }
    //public static void AgregarAlumno(Alumno nuevoAlumno)
    //        {
    //            var alumnos = ObtenerAlumnos();
    //            nuevoAlumno.Id = DatosCompartidos.ObtenerNuevoIdAlumno(alumnos);
    //            alumnos.Add(nuevoAlumno);
    //            GuardarAlumnos(alumnos);
    //        }

    //        private static Alumno? BuscarAlumnoPorId(List<Alumno> lista, int id)
    //        {
    //            foreach (var alumno in lista)
    //            {
    //                if (alumno.Id == id)
    //                {
    //                    return alumno;
    //                }
    //            }

    //            return null;
    //        }

    //        public static Alumno? BuscarPorId(int id)
    //        {
    //            var lista = ObtenerAlumnos();
    //            return BuscarAlumnoPorId(lista, id);
    //        }

    //        public static void EliminarPorId(int id)
    //        {
    //            var lista = ObtenerAlumnos();
    //            var alumnoAEliminar = BuscarAlumnoPorId(lista, id);
    //            if (alumnoAEliminar != null)
    //            {
    //                lista.Remove(alumnoAEliminar);
    //                GuardarAlumnos(lista);
    //            }

    //        }
    //        public static void EditarAlumno(Alumno alumnoEditado)
    //        {
    //            var lista = ObtenerAlumnos();
    //            var alumno = BuscarAlumnoPorId(lista, alumnoEditado.Id);

    //            if (alumno != null)

    //            {
    //                alumno.Nombre = alumnoEditado.Nombre;
    //                alumno.Apellido = alumnoEditado.Apellido;
    //                alumno.DNI = alumnoEditado.DNI;
    //                alumno.Email = alumnoEditado.Email;
    //                alumno.FechaDeNacimiento = alumnoEditado.FechaDeNacimiento;


    //                GuardarAlumnos(lista);
    //            }
    //        }

    //    }
}