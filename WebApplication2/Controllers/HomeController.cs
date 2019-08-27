using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpPost]
        public ActionResult Index(string Valutes, DateTime StartDate, DateTime EndDate, string action)
        {
            try
            {
                
                CursModel c = new CursModel();
                ViewBag.Valutes = c.GetValutes();
                Console.WriteLine(action);
                Console.WriteLine("StartDate," + StartDate + " EndDate, " + EndDate + " Valutes, " + Valutes);
                if (action == "GetCurCurs")
                {
                    ViewBag.Act = true;
                    ViewBag.CurCurs=c.GetCursOnDate();
                }
                else if (action == "GetDynamicCurs")
                {
                    ViewBag.Act = false;
                    Console.WriteLine("StartDate," + StartDate+" EndDate, " + EndDate + " Valutes, " + Valutes);
                    ViewBag.DynCurs = c.GetDynamicCurs(StartDate,EndDate, Valutes);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
               
            }
            return View();
        }



        public IActionResult Index()
        {
            CursModel c = new CursModel();
            
            ViewBag.Valutes = c.GetValutes();
            return View();
        }
        [HttpGet]
        public IActionResult getCurrentCurses()
        {
            try
            {
                CursModel c = new CursModel();

                CURSES curses = c.GetCursOnDate();

                return View(curses);

            }
            catch (Exception ex)
            {
                Console.WriteLine("controllerEX - " + ex.ToString());
                return View();
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

        public IActionResult Privacy()
        {
            

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
