using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace educonaturel.Controllers
{
    public class SalleEveilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}