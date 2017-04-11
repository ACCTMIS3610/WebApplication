using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BestBIdEnergy.Controllers
{
    [Authorize]
    public class SuppliersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Supplier")]
        public IActionResult Profile()
        {
            return View();
        }

        [Authorize(Roles = "Supplier")]
        public IActionResult Auction()
        {
            return View();
        }

        [Authorize(Roles = "Supplier")]
        public IActionResult Contracts()
        {
            return View();
        }
    }
}