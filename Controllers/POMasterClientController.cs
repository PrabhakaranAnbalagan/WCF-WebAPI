using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWebAPIAssignment.Controllers
{
    public class POMasterClientController : Controller
    {
        // GET: POMasterClient
        [Route("POMasters")]
        public ActionResult POMaster()
        {
            return View();
        }
    }
}