using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstProject.Models;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
                public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            //Ternary oprator -- It has 3 parts: Predicate, True, False.
            //Predicate: hour < 12
            //True: ? "Good Morning"
            //False: : "Good Afternoon"
            string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView", viewModel);
        }
    }
}
