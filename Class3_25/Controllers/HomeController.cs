using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class3_25.Models;

namespace Class3_25.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            string value = Request.Cookies["number"];
            bool first = String.IsNullOrEmpty(value);
            int num = int.Parse(value);
            if (!first)
            {
                num = 1;
                Response.Cookies.Append("number", $"{num}");               
               
            }
            else
            {
                num++;
            }
            return View(num);
        }

        
    }
}
