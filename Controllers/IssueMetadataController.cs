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
    public class IssueMetadataController : ApiController
    {
        private IssueMetadataContext db = new IssueMetadataContext();

        // GET api/IssueMetadata
        public IEnumerable<IssueMetadata> GetIssueMetadatas()
        {
            return db.IssueMetadata.AsEnumerable();
        }

        // GET api/IssueMetadata/5
        public IEnumerable<IssueMetadata> GetIssueMetadata(int id)
        {
            var imds = new List<IssueMetadata>();
            foreach (var imd in db.IssueMetadata)
            {
                if (imd.PageViewId == id)
                {
                    imds.Add(imd);
                }
            }
            return imds;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}