using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Form_Submit_AJAX_MVC_Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(string firstName, string lastName)
        {
            string name = string.Format("Name: {0} {1}", firstName, lastName); ;
            return Json(new { Status = "success", Name = name });
        }
    }
}