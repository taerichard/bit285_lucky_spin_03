using System;
using Microsoft.AspNetCore.Mvc;
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Random random = new Random();

        //The Conroller to receive the Luck number from the Route
        
        public IActionResult Index(int luck) //Default value for luck is 7
        {
            // working on dependency injection for question 5.  DInjecting TextTransformService in index.cshtml
            Spin spin = new Spin();
            int a = spin.A = random.Next(1, 10);
            int b = spin.B = random.Next(1, 10);
            int c = spin.C = random.Next(1, 10);
             spin.LuckyNumber = luck;
            string imageDis = spin.imageDisplayValue = (a == luck || b == luck || c == luck) ? "block" : "none";

            return View(spin);



            /*
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);


            // Load up the ViewBag for use by the Spinner View "Index.cshtml"
            ViewBag.ImgDisplay = (a == luck || b == luck || c == luck)?"block":"none";
            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.C = c;
            ViewBag.luck = luck;

            return View();
            */
        }
    }
}