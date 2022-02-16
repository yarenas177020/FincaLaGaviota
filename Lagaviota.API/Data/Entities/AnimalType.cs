using System.ComponentModel.DataAnnotations;

namespace Lagaviota.API.Data.Entities
{
    public class AnimalType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de Animal")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; }


    }
}
