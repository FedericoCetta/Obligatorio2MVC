using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionProductosMVC.Models
{
    public class Usuario
    {
        //WOW
        //hola pollo
        [Key]
        public int idUsuario { get; set; }
        [EmailAddress][Required]
        public string Email { get; set; }
        [Required][MinLength(4)]
        public string Password { get; set; }
    
       
    }
}