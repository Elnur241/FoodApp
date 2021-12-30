using FoodApp.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FoodApp.Controllers
{
 
    public class LoginController : Controller
    {
        Context context = new Context();
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Admin admin)
        {
           var user= context.admins.FirstOrDefault(x => x.userName == admin.userName && x.password == admin.password);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admin.userName)
                };
            ClaimsIdentity id = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principla = new ClaimsPrincipal(id);
                await HttpContext.SignInAsync(principla);
                return RedirectToAction("Index", "Category");
            }
            return View();
           
        }
        public async Task<IActionResult> logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}
