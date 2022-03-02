using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lagaviota.API.Data.Entities
{
    public class Operator
    {
        public int Id { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public ICollection<Photo> Photos { get; set; }

        //TODO: Fix the Images path
        [Display(Name = "Foto")]
        public string ImageFullPath => Photos == null || Photos.Count == 0
            ? $"https://localhost:5001/images/nophoto.png"
            : Photos.FirstOrDefault().ImageFullPath;
    }
}
