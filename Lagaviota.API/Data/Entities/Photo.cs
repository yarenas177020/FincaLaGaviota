using System;
using System.ComponentModel.DataAnnotations;

namespace Lagaviota.API.Data.Entities
{
    public class Photo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Dog Dog { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }

        //TODO: Fix the Images path
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:5001/images/nophoto.png"
            : $"https://localhost:5001/users/{ImageId}";

    }
}
