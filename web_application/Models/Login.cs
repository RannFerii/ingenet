using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_application.Models
{

    public class Login
    {
        [Required(ErrorMessage = "Correo requerido")]
        [Display(Name = "Correo Electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Cotraseña { get; set; }

        [Display(Name = "Recordarme")]
        public bool Rememberme { get; set; }
    }
}