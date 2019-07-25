using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EFWebAPIAssignment.Models;

namespace EFWebAPIAssignment.Controllers
{
    public class POMasterController : ApiController
    {
        // GET: api/POMaster
        [Route("pomaster/GetAll")]
        public IEnumerable<POMASTER> Get()
        {
            using (PODbEntities db = new PODbEntities())
            {
                return db.POMASTERs.ToList();
            }
        }

        // GET: api/POMaster/5
        [Route("pomaster/Get/{PONO}")]
        public POMASTER Get(String PONO)
        {
            using (PODbEntities db = new PODbEntities())
            {
                return db.POMASTERs.Find(PONO);
            }
        }

        // POST: api/POMaster
        [Route("pomaster/Add")]
        [HttpPost]
        public void Post([FromBody]POMASTER item)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.POMASTERs.Add(item);
                db.SaveChanges();
            }
        }

        // PUT: api/POMaster/5
        [Route("pomaster/Edit")]
        public void Put([FromBody]POMASTER item)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/POMaster/5
        [Route("pomaster/Delete/{PONO}")]
        public void Delete(String PONO)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.POMASTERs.Remove(db.POMASTERs.Find(PONO));
                db.SaveChanges();
            }
        }
    }
}
