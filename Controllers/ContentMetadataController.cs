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
    public class ContentMetadataController : ApiController
    {
        private ContentMetadataContext db = new ContentMetadataContext();

        // GET api/ContentMetadata
        public IEnumerable<ContentMetadata> GetContentMetadatas()
        {
            return db.ContentMetadata.AsEnumerable();
        }

        // GET api/ContentMetadata/5
        public IEnumerable<ContentMetadata> GetContentMetadata(int id)
        {
            var cmds = new List<ContentMetadata>();
            foreach (var cmd in db.ContentMetadata)
            {
                if (cmd.PageViewId == id)
                {
                    cmds.Add(cmd);
                }
            }
            return cmds;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}