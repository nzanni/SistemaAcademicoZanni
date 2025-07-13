using SistemaAcademicoZanni.Models;
using System.Text.Json;
using static SistemaAcademicoZanni.Data.DatosCompartidosModel;


namespace SistemaAcademicoZanni.Servicios
{
    public static class ServicioCarrera
    {
        private static string ruta = "Data/carreras.json";

        public static string LeerTextoDelArchivo()
        {
            if (File.Exists("Data/carreras.json"))
            {
                return File.ReadAllText("Data/carreras.json");
            }

            return "[]";
        }
        public static List<Carrera> ObtenerCarreras()
        {
            string json = LeerTextoDelArchivo();
            var lista = JsonSerializer.Deserialize<List<Carrera>>(json);
            return lista ?? new List<Carrera>();
        }
        public static void GuardarCarreras(List<Carrera> carreras)
        {
            string textoJson = JsonSerializer.Serialize(carreras);
            File.WriteAllText("Data/carreras.json", textoJson);
        }
        public static void AgregarCarrera(Carrera nuevaCarrera)
        {
            var carreras = ObtenerCarreras();
            nuevaCarrera.Id = DatosCompartidos.ObtenerNuevoIdCarrera(carreras);
            carreras.Add(nuevaCarrera);
            GuardarCarreras(carreras);
        }

        private static Carrera? BuscarCarreraPorId(List<Carrera> lista, int id)
        {
            foreach (var carrera in lista)
            {
                if (carrera.Id == id)
                {
                    return carrera;
                }
            }

            return null;
        }

        public static Carrera? BuscarPorId(int id)
        {
            var lista = ObtenerCarreras();
            return BuscarCarreraPorId(lista, id);
        }

        public static void EliminarPorId(int id)
        {
            var lista = ObtenerCarreras();
            var carreraAEliminar = BuscarCarreraPorId(lista, id);
            if (carreraAEliminar != null)
            {
                lista.Remove(carreraAEliminar);
                GuardarCarreras(lista);
            }

        }
        public static void EditarCarrera(Carrera carreraEditada)
        {
            var lista = ObtenerCarreras();
            var carrera = BuscarCarreraPorId(lista, carreraEditada.Id);

                if (carrera != null)

                {
                    carrera.Nombre = carreraEditada.Nombre;
                    carrera.Modalidad = carreraEditada.Modalidad;
                    carrera.DuracionAnios = carreraEditada.DuracionAnios;
                    carrera.TituloOtorgado = carreraEditada.TituloOtorgado;

            GuardarCarreras(lista);
            }
        }

    }
}
