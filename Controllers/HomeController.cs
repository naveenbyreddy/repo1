using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApiAssignment.Models;

namespace WebApiAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            IEnumerable<Details> empdata = null;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = "https://localhost:44366/api/";

                var json = webClient.DownloadString("Values");
                var list = JsonConvert.DeserializeObject<List<Details>>(json);
                empdata = list.ToList();
                return View(empdata);

            }

        }
    }
}
