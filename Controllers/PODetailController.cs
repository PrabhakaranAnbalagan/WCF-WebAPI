using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EFWebAPIAssignment.Models;

namespace EFWebAPIAssignment.Controllers
{
    public class PODetailController : ApiController
    {
        // GET: api/PODetail
        [Route("podetail/GetAll")]
        public IEnumerable<PODETAIL> Get()
        {
            using (PODbEntities db = new PODbEntities())
            {
                return db.PODETAILs.ToList();
            }
        }

        // GET: api/PODetail/5
        [Route("podetail/Get/{PONO}")]
        public PODETAIL Get(String PONO)
        {
            using (PODbEntities db = new PODbEntities())
            {
                return db.PODETAILs.SingleOrDefault(m => m.PONO == PONO); 
            }
        }

        // POST: api/PODetail
        [Route("podetail/Add")]
        [HttpPost]
        public void Post([FromBody]PODETAIL item)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.PODETAILs.Add(item);
                db.SaveChanges();
            }
        }

        // PUT: api/PODetail/5
        [Route("podetail/Edit")]
        public void Put([FromBody]PODETAIL item)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/PODetail/5
        [Route("podetail/Delete/{PONO}")]
        public void Delete(String PONO)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.PODETAILs.Remove(db.PODETAILs.SingleOrDefault(m => m.PONO == PONO)); 
                db.SaveChanges();
            }
        }
    }
}
