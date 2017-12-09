using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_application.Models
{
    [MetadataType(typeof(VUsuario))]
    public partial class Usuario
    {
        class VUsuario
        {
            [Required(ErrorMessage = "Campo requerido")]
            [StringLength(50)]
            [DisplayName("Nombre(s)")]
            public string Nombres { get; set; }

            [Required(ErrorMessage = "Campo requerido")]
            [StringLength(50)]
            [DisplayName("Apellido paterno")]
            public string ApellidoPaterno { get; set; }

            [Required(ErrorMessage = "Campo requerido")]
            [StringLength(50)]
            [DisplayName("Apellido materno")]
            public string ApellidoMaterno { get; set; }

            [Required(ErrorMessage = "Campo requerido")]
            [StringLength(20)]
            [DisplayName("Nombre de usuario")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "Campo requerido")]
            [StringLength(50)]
            [DataType(DataType.EmailAddress)]
            [DisplayName("E-mail")]
            public string Correo { get; set; }

            [Required(ErrorMessage = "Campo requerido")]
            [StringLength(20)]
            [DataType(DataType.Password)]
            [DisplayName("Contraseña")]
            public string Contraseña { get; set; }

            [Required(ErrorMessage = "Campo requerido")]
            [DisplayName("Ocupación")]
            public int Ocupacion { get; set; }

            [Required(ErrorMessage = "Campo requerido")]
            [StringLength(5)]
            [DisplayName("Rol")]
            public string Rol { get; set; }

            [Required(ErrorMessage = "Campo requerido")]
            [DisplayName("Sexo")]
            public bool Sexo { get; set; }

            [Required(ErrorMessage = "Campo requerido")]
            [DisplayName("Estatus")]
            public int Carrera { get; set; }

            [Required(ErrorMessage = "Campo requerido")]
            [DisplayName("Estatus")]
            public int Estatus { get; set; }
            
            [DisplayName("Foto de perfil")]
            public byte[] Foto { get; set; }

        }
    }
}