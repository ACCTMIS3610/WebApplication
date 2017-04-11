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
        [Authorize(Roles = "Buyer")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Contracts()
        {
            return View();
        }

        public IActionResult NewContract()
        {
            return View();
        }
    }
}