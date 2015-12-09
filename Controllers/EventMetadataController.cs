using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using KendoUIgrid.Models;

namespace KendoUIgrid.Controllers
{
    public class EventMetadataController : ApiController
    {
        private EventMetadataContext db = new EventMetadataContext();

        // GET api/EventMetadata
        public IEnumerable<EventMetadata> GetEventMetadatas()
        {
            return db.EventMetadata.AsEnumerable();
        }

        // GET api/EventMetadata/5
        public IEnumerable<EventMetadata> GetEventMetadata(int id)
        {
            var amds = new List<EventMetadata>();
            foreach (var amd in db.EventMetadata)
            {
                if (amd.PageViewId == id)
                {
                    amds.Add(amd);
                }
            }
            return amds;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}