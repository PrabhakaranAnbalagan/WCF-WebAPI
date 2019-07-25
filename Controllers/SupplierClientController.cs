using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWebAPIAssignment.Controllers
{
    public class SupplierClientController : Controller
    {
        // GET: SupplierClient
        [Route("Suppliers")]
        public ActionResult Supplier()
        {
            return View();
        }
    }
}