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

        [Display(Name="Canino")]
        public ICollection<Dog> Dog { get; set; }


        //[Display(Name = "Equino")]
        //public Horse Horse { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime Date { get; set; }

        [Display(Name = "Procedimiento")]
        public ICollection<Procedure> Procedure { get; set; }

        [Display(Name = "Observación")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

       

       
    }
}
