﻿using System.ComponentModel.DataAnnotations;

namespace SistemaAcademicoZanni.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public int DNI { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime FechaDeNacimiento { get; set; }
    }
}
