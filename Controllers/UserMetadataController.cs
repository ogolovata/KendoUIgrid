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
    public class UserMetadataController : ApiController
    {
        private UserMetadataContext db = new UserMetadataContext();

        // GET api/UserMetadata
        public IEnumerable<UserMetadata> GetUserMetadatas()
        {
            return db.UserMetadata.AsEnumerable();
        }

        // GET api/UserMetadata/5
        public IEnumerable<UserMetadata> GetUserMetadata(int id)
        {
            var umds = new List<UserMetadata>();
            foreach (var umd in db.UserMetadata)
            {
                if (umd.PageViewId == id)
                {
                    umds.Add(umd);
                }
            }
            return umds;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}