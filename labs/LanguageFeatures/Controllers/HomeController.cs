using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }

        //action method
        //NOTICE:
        // the => ni the expression bodied method
        // IS NOT THE SAME AS
        // the => in the lambda expression
        public ViewResult Index()   //create an expression bodied method
        {
            var products = new[] {
             new { Name = "Kayak", Price = 275M }, //object initializer syntax
             new { Name = "Lifejacket", Price = 48.95M },
             new { Name = "Soccer ball", Price = 19.50M },
             new { Name = "Corner flag", Price = 34.95M },
             new { Name = "Beer Cooler", Price = 14.95M }
        };
            return View(products.Select(p => p.GetType().Name));
        }

    }
}

/*
 * * an expression bodied method is a real method, just a different syntax
 *  */
/*
 * 1 - Lambda expression allow you to pass function as arguments to methods
 * 2 -lambdas allow you to create anonymous methods
 * 3 - lambdas inline code (rather than creating a new execution stack)
 * */