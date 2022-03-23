using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lagaviota.API.Data.Entities
{
    public class History
    {
        public int Id { get; set; }

        [Display(Name = "Fecha de Registro:")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "Animal")]
        public ICollection<Dog> Dogs { get; set; }

        [Display(Name = "Usuario")]
        public ICollection<User> Users { get; set; }

        [Display(Name = "Veterinario / Operario")]
        public ICollection<Operator> Operators { get; set; }


    }
}
