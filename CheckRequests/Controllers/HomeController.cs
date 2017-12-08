using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheckRequests.Models;

namespace CheckRequests.Controllers
{
    public class HomeController : Controller
    {
        readonly VantEDGEPointEntities _context = new VantEDGEPointEntities();

        public ActionResult Index()
        {
            List<check_request> activeCheckRequests = new List<check_request>();
            

            activeCheckRequests = _context.check_request.Where(x => x.business_action != 1 &&
                                                                       x.business_action != 2).ToList();

            return View(activeCheckRequests);
        }

        public ActionResult Details(int id)
        {
            var details = _context.check_request_detail.FirstOrDefault(x => x.check_request == id);
            return View(details);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}