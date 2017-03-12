using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NumberFun.Models;

namespace NumberFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NumberInfo(string number)
        {
            int num;
            if( int.TryParse(number, out num))
            {
                NumberProperties numberProp = new NumberProperties(num);
                
                return View(numberProp);
            }
            else
            {
                return Error();
            }
            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
