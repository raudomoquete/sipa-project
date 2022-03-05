using SiPA.API.Data.Entities;
using SiPA.API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiPA.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(
            DataContext context,
            IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRoles();
            var church = await CheckUserChurchAsync("Parroquia San Agustin", "sanchezz1ero@gmail.com", "809-598-2314",
                "C. La Romana Esquina Higuey, Santo Domingo Este","Administrator");
            var parishioner = await CheckUserParishionerAsync("Borgia", "Sánchez", "borgiasanchez15@gmail.com", "829-906-2954",
                "Customer");
            await CheckChurchAsync(church);
            await CheckParishionerAsync(parishioner);
        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Administrator");
            await _userHelper.CheckRoleAsync("Customer");
        }

        private async Task<User> CheckUserChurchAsync(string churchName, string email,
          string phone, string address, string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    ChurchName = churchName,
                    Email = email,
                    PhoneNumber = phone,
                    Address = address
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, role);
            }

            return user;
        }

        private async Task<User> CheckUserParishionerAsync(string firstName, string lastName, string email,
            string phone, string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = phone
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, role);
            }

            return user;
        }

        private async Task CheckChurchAsync(User user)
        {
            if (!_context.Churches.Any())
            {
                _context.Churches.Add(new Church { User = user });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckParishionerAsync(User user)
        {
            if (!_context.Parishioners.Any())
            {
                _context.Parishioners.Add(new Parishioner { User = user });
                await _context.SaveChangesAsync();
            }
        }
    }
}
