using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EFWebAPIAssignment.Models;

namespace EFWebAPIAssignment.Controllers
{
    public class SupplierController : ApiController
    {
        // GET: api/Supplier
        [Route("supplier/GetAll")]
        public IEnumerable<SUPPLIER> Get()
        {
            using (PODbEntities db = new PODbEntities())
            {
                return db.SUPPLIERs.ToList();
            }
        }

        // GET: api/Supplier/5
        [Route("supplier/Get/{SUPLNO}")]
        public SUPPLIER Get(String SUPLNO)
        {
            using (PODbEntities db = new PODbEntities())
            {
                return db.SUPPLIERs.Find(SUPLNO);
            }
        }

        // POST: api/Supplier
        [Route("supplier/Add")]
        [HttpPost]
        public void Post([FromBody]SUPPLIER item)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.SUPPLIERs.Add(item);
                db.SaveChanges();
            }
        }

        // PUT: api/Supplier/5
        [Route("supplier/Edit")]
        public void Put([FromBody]SUPPLIER item)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/Supplier/5
        [Route("supplier/Delete/{SUPLNO}")]
        public void Delete(String SUPLNO)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.SUPPLIERs.Remove(db.SUPPLIERs.Find(SUPLNO));
                db.SaveChanges();
            }
        }
    }
}
