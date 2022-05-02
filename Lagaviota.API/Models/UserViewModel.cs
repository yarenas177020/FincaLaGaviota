using Lagaviota.API.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lagaviota.API.Models
{
    public class UserViewModel : User 
    {
        [Display(Name = "Nombre Usuario")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Username { get; set; }

        [Display(Name = "Tipo de Usuario")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string UserTypeId { get; set; }

        public IEnumerable<SelectListItem> UserTypes { get; set; }
    }
}
