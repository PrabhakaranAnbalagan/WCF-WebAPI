using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWebAPIAssignment.Controllers
{
    public class PODetailClientController : Controller
    {
        // GET: PODetailClient
        [Route("PODetails")]
        public ActionResult PODetail()
        {
            return View();
        }
    }
}