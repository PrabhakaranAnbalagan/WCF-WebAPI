using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EFWebAPIAssignment.Models;

namespace EFWebAPIAssignment.Controllers
{
    public class ItemController : ApiController
    {
        // GET: api/Item
        [Route("item/GetAll")]
        public IEnumerable<ITEM> Get()
        {
            using (PODbEntities db = new PODbEntities())
            {
                return db.ITEMs.ToList();
            }
        }

        // GET: api/Item/5
        [Route("item/Get/{ITCODE}")]
        public ITEM Get(String ITCODE)
        {
            using (PODbEntities db = new PODbEntities())
            {
                return db.ITEMs.Find(ITCODE);
            }
        }

        // POST: api/Item
        [Route("item/Add")]
        [HttpPost]
        public void Post([FromBody]ITEM item)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.ITEMs.Add(item);
                db.SaveChanges();
            }
        }

        // PUT: api/Item/5
        [Route("item/Edit")]
        public void Put([FromBody]ITEM item)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/Item/5
        [Route("item/Delete/{ITCODE}")]
        public void Delete(String ITCODE)
        {
            using (PODbEntities db = new PODbEntities())
            {
                db.ITEMs.Remove(db.ITEMs.Find(ITCODE));
                db.SaveChanges();
            }
        }
    }
}
