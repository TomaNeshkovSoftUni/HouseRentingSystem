using HouseRentingSystem.App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HouseRentingSystem.App.Controllers
{
    public class AutoController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid == false)
            {
                return View(model);
            }

            return View();
        }
    }
}
