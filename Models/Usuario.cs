
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using YoureOnGenNHibernate.Enumerated.YoureOn;


namespace WebApplication1.Models
{
    public class Usuario
    {

        /* email, nombre, apellidos, fechaNac, niF, foto, contraseña*/
        [Required(ErrorMessage = "Éste dato es requerido")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Éste dato es requerido")]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Éste dato es requerido")]
        [DataType(DataType.Text)]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Éste dato es requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime? FechaNac { get; set; }

        [Required(ErrorMessage = "Éste dato es requerido")]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 8)]
        [DataType(DataType.Text)]
        [Display(Name = "NIF")]
        public string NIF { get; set; }


        [DataType(DataType.ImageUrl)]
        [Display(Name = "Foto de perfil")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "Éste dato es requerido")]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Contrasenya { get; set; }

    }
}

