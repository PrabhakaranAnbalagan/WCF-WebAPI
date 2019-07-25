using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWebAPIAssignment.Controllers
{
    public class ItemClientController : Controller
    {
        // GET: ItemClient
        [Route("Items")]
        public ActionResult Item()
        {
            return View();
        }
    }
}