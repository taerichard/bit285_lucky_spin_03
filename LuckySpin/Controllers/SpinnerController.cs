using System;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {

       
        public IActionResult Index(int luck) //Default value for luck is 7
        {

            Random random = new Random();
            // working on dependency injection for question 5.  DInjecting TextTransformService in index.cshtml
            Spin spin = new Spin();
            int a = spin.A = random.Next(1, 10);
            int b = spin.B = random.Next(1, 10);
            int c = spin.C = random.Next(1, 10);
            spin.LuckyNumber = luck;
            spin.ImageDisplayValue = (a == luck || b == luck || c == luck) ? "block" : "none";

            return View(spin);
        }
    }
}