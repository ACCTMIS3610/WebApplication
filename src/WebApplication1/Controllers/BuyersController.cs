using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.AccountViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    
    public class BuyersController : Controller
    {
        // GET: /<controller>/
        
        //[AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [Authorize(Roles = "Buyer")]
        public IActionResult Profile()
        {
            return View();
        }
        [Authorize(Roles = "Buyer")]
        public IActionResult Contracts()
        {
            return View();
        }
        [Authorize(Roles = "Buyer")]
        public IActionResult NewContract()
        {
            return View();
        }
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
    }
}