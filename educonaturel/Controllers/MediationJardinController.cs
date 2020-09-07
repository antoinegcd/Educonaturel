using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace educonaturel.Controllers
{
    public class MediationJardinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}