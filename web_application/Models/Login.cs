using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNETMVCBlank.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "Correo Electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Cotraseña { get; set; }

        [Display(Name = "Recordarme")]
        public bool Rememberme { get; set; }
    }
}