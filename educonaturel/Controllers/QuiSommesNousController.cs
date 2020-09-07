using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace educonaturel.Controllers
{
    public class QuiSommesNousController : Controller
    {
        // GET: QuiSommesNous
        public ActionResult Index()
        {
            return View();
        }
    }
}