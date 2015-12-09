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
    public class MapMetadataController : ApiController
    {
        private MapMetadataContext db = new MapMetadataContext();

        // GET api/MapMetadata
        public IEnumerable<MapMetadata> GetMapMetadatas()
        {
            return db.MapMetadata.AsEnumerable();
        }

        // GET api/MapMetadata/5
        public IEnumerable<MapMetadata> GetMapMetadata(int id)
        {
            var mmds = new List<MapMetadata>();
            foreach (var mmd in db.MapMetadata)
            {
                if (mmd.PageViewId == id)
                {
                    mmds.Add(mmd);
                }
            }
            return mmds;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}