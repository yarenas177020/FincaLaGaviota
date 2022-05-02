using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lagaviota.API.Data.Entities
{
    public class Horse
    {
        public int Id { set; get; }

        [Display(Name = "Nombre")]
        public string Name { set; get; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime BornDate { set; get; }

        public string Color { set; get; }

        [Display(Name = "Sexo")]
        public string Gender { set; get; }

       
        public ICollection<History> Histories { get; set; }
        [Display(Name = "# Historias")]
        public int HistoriesCount => Histories == null ? 0 : Histories.Count;

        public ICollection<Photo> Photos { get; set; }

        //TODO: Fix the Images path
        [Display(Name = "Foto")]
        public string ImageFullPath => Photos == null || Photos.Count == 0
           ? $"https://localhost:5001/images/nophoto.png"
           : Photos.FirstOrDefault().ImageFullPath;

    }
}
