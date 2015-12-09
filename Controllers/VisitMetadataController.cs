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
    public class VisitMetadataController : ApiController
    {
        private VisitMetadataContext db = new VisitMetadataContext();

        // GET api/VisitMetadata
        public IEnumerable<VisitMetadata> GetVisitMetadatas()
        {
            return db.VisitMetadata.AsEnumerable();
        }

        // GET api/VisitMetadata/5
        public IEnumerable<VisitMetadata> GetVisitMetadata(int id)
        {
            var vmds = new List<VisitMetadata>();
            foreach (var vmd in db.VisitMetadata)
            {
                if (vmd.PageViewId == id)
                {
                    vmds.Add(vmd);
                }
            }
            return vmds;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}