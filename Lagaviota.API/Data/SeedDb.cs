using Lagaviota.API.Data.Entities;
using Lagaviota.API.Helpers;
using Lagaviota.Common.Enums;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lagaviota.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckProceduresAsync();
            await CheckRolesAsync();
            await CheckUserAsync("lvelez","Luis","Velez", UserType.User);
            await CheckUserAsync("yarenas", "Yeison", "Arenas", UserType.Admin);
        }

        private async Task CheckUserAsync(string username, string name, string lastname, UserType userType)
        {
            User user= await _userHelper.GetUserAsync(username);
            if (user == null)
            {
                user = new User
                {
                    FirstName = name,
                    LastName = lastname,
                    UserName = username,
                    UserType = userType
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }
        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
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

       
    }
}
