using Lagaviota.API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lagaviota.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckAnimalTypesAsync();
            await CheckProceduresAsync();
        }

        private async Task CheckProceduresAsync()
        {
            if (!_context.Procedures.Any())
            {
                _context.Procedures.Add(new Procedure { Description = "Vacuna" });
                _context.Procedures.Add(new Procedure { Description = "Herraje" });
                _context.Procedures.Add(new Procedure { Description = "Desparacitación" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckAnimalTypesAsync()
        {
            if (!_context.animalTypes.Any())
            {
                _context.animalTypes.Add(new AnimalType { Description = "Caballo" });
                _context.animalTypes.Add(new AnimalType { Description = "Perro" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
