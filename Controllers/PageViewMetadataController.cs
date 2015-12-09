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
    public class PageViewMetadataController : ApiController
    {
        private PageViewMetadataContext db = new PageViewMetadataContext();

        // GET api/PageViewMetadata
        public IEnumerable<PageViewMetadata> GetPageViewMetadatas()
        {
            return db.PageViewMetadata.AsEnumerable();
        }

        // GET api/PageViewMetadata/5
        public IEnumerable<PageViewMetadata> GetPageViewMetadata(int id)
        {
            var pvmds = new List<PageViewMetadata>();
            foreach (var pvmd in db.PageViewMetadata)
            {
                if (pvmd.PageViewId == id)
                {
                    pvmds.Add(pvmd);
                }
            }
            return pvmds;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}