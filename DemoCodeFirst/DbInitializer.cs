using DemoCodeFirst.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DemoCodeFirst.DatabaseInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            if (_db.Users.Any())
            {
                return;
            }
            else
            {
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "tvb-ugoz@gmail.com",
                    Email = "tvb-ugoz@gmail.com",
                    EmailConfirmed = true,
                    FirstName = "Tineke",
                    MiddleName = "van",
                    LastName = "Breukelen"
                }, "UgOz!2021").GetAwaiter().GetResult();
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "j.van.gaalen@gmail.com",
                    Email = "j.van.gaalen@gmail.com",
                    EmailConfirmed = true,
                    FirstName = "Jan",
                    MiddleName = "van",
                    LastName = "Gaalen"
                }, "UgOz!2021").GetAwaiter().GetResult();
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "s.bosman@gmail.com",
                    Email = "s.bosman@gmail.com",
                    EmailConfirmed = true,
                    FirstName = "Simon",
                    LastName = "Bosman"
                }, "UgOz!2021").GetAwaiter().GetResult();
            }
        }
    }
}
