using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _8383Core.Models;
using Logic;

namespace _8383Core.Controllers
{
    public class HomeController : Controller
    {

        private PlanLogic pLogic = new PlanLogic();

        public IActionResult Index()
        {
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

        [HttpPost]
        public ActionResult Submit(string datastream)
        {
            string[] data = datastream.Split(';');
            string from = data[0];
            string to = data[1];
            string arrival = data[2];


            pLogic.GetPlan(from, to, arrival);
            return RedirectToAction(nameof(Index));
        }
    }
}
