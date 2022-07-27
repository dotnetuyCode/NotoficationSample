using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NotoficationSample.Controllers
{
    public class ModulesController1 : Controller
    {
        public IActionResult Module1()
        {
            return View();
        }

        public IActionResult Module2()
        {
            return View();
        }

        public IActionResult Module3()
        {
            return View();
        }
    }
}
