using Lagaviota.API.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lagaviota.API.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context, UserHelper userHelper)
        {
            _context = context;
        }
        public IEnumerable<SelectListItem> GetComboDog()
        {
            List<SelectListItem> list = _context.Dogs.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = $"{x.Id}"
            })
                .OrderBy(x => x.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un canino...]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboHorse()
        {
            List<SelectListItem> list = _context.Horses.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = $"{x.Id}"
            })
                .OrderBy(x => x.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un equino...]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboProcedures()
        {
            List<SelectListItem> list = _context.Procedures.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = $"{x.Id}"
            })
                 .OrderBy(x => x.Text)
                 .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un procedimiento...]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboUserTypes()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un tipo de usuario...]",
                Value = "0"
            });

            list.Insert(0, new SelectListItem
            {
                Text = "[Administrador]",
                Value = "Admin"
            });

            list.Insert(0, new SelectListItem
            {
                Text = "[Usuario]",
                Value = "User"
            });
            return list;
        }


    }
}
