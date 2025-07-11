using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademicoZanni.Models;

namespace SistemaAcademicoZanni.Pages.Alumnos
{
        public class IndexModel : PageModel
        {
            public List<Alumno> Alumnos { get; set; } = new();

            public void OnGet()
            {
                var alumno1 = new Alumno
                {
                    Id = 1,
                    Nombre = "Sofía",
                    Apellido = "Pérez",
                    DNI = 40123456,
                    Email = "sofia.perez@email.com",
                    FechaDeNacimiento = new DateTime(2002, 5, 20)
                };

                var alumno2 = new Alumno
                {
                    Id = 2,
                    Nombre = "Lucas",
                    Apellido = "Gómez",
                    DNI = 38987654,
                    Email = "lucas.gomez@email.com",
                    FechaDeNacimiento = new DateTime(2000, 9, 15)
                };

                Alumnos.Add(alumno1);
                Alumnos.Add(alumno2);
            }
        }
    }

