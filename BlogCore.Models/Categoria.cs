using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Ingresa un nombre para la categoria")]
        [Display(Name ="Nombre Categoria")]

        public string Nombre { get; set; }

        [Required]      
        [Display(Name = "Orden de visualización")]
        public int Orden { get; set; }
    }
}
