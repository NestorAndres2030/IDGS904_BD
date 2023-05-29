using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS904_BD.Models
{
    public class Alumnos
    {
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }
    
        [StringLength(50)]
        public string Correo { get; set;}


    }
}