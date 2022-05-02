using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lagaviota.API.Data.Entities
{
    public class Detail
    {
        public int Id { get; set; }

        [Display(Name="Historia")]
        [Required(ErrorMessage="El campo {0} es obligatorio.")]
        public History History { get; set; }

        [Display(Name = "Procedimiento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public ICollection<Procedure> Procedures { get; set; }

        [Display(Name = "Observación")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Remarks { get; set; }

        
    }
}
