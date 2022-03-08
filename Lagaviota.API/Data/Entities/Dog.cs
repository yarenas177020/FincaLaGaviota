using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lagaviota.API.Data.Entities
{
    public class Dog
    {
        public int Id { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        [Display(Name = "Fecha de Nacimiento:")]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Sexo:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Gender { get; set; }

        [Display(Name = "Color:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        public string Color { get; set; }

        [Display(Name = "Raza:")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        public string breed { get; set; }

        public ICollection<Photo> Photos { get; set; }

        
        //TODO: Fix the Images path
        [Display(Name = "Foto")]
        public string ImageFullPath => Photos == null || Photos.Count == 0
            ? $"https://localhost:5001/images/nophoto.png"
            : Photos.FirstOrDefault().ImageFullPath;
    }
}
