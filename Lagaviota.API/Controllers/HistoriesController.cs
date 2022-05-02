using Lagaviota.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Lagaviota.API.Controllers
{
    [Authorize(Roles ="Admin")]
    public class HistoriesController : Controller
    {
        private readonly DataContext _context;
       
        public HistoriesController(DataContext context)
        {
            _context = context;
        }
    
        public async Task<IActionResult> Index()
        {
            return View(await _context.Histrories
                //.Include(x => x.Date)
                //.Include(x=> x.Dog.Name)
                .ToListAsync());
        }
    
    }

    
}
