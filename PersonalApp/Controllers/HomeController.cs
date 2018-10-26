using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalApp.Service;
using PersonalApp.Models;
using System.Diagnostics;

namespace PersonalApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HistoricalDataService histDataService = new HistoricalDataService();
            List<HistoricalData> histDataList = histDataService.getHistDataBySymbolanDuration("fb","1m");
            Debug.WriteLine(histDataList.Count);
            ViewData["histData"] = histDataList;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}