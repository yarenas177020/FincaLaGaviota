using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lagaviota.API.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboDog();
        IEnumerable<SelectListItem> GetComboHorse();
        IEnumerable<SelectListItem> GetComboProcedures();
        IEnumerable<SelectListItem> GetComboUserTypes();


    }
}
