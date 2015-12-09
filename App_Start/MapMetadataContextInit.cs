using System.Collections.Generic;
using System.Data.Entity;
using KendoUIgrid.Models;
using System;

namespace KendoUIgrid.App_Start
{
    public class MapMetadataContextInit : DropCreateDatabaseAlways<MapMetadataContext>
    {
        private int _entities = 3;
        private int _id = 1;
        private Random _rnd = new Random();

        public MapMetadataContextInit(int entities)
        {
            _entities = entities;
        }
        protected override void Seed(MapMetadataContext context)
        {
            var properties = new Dictionary<string, List<string>>()
            { 
                { "latitude", new List<string>(){ "41.2389135330717" } },
                { "longitude", new List<string>() { "-95.9309396268035" } },
                { "continent", new List<string>() { "north america" } },
                { "country", new List<string>() { "united states" } },
                { "region", new List<string>() { "NE" } },
                { "state", new List<string>() { "nebraska" } },
                { "city", new List<string>() { "omaha" } },
                { "zip", new List<string>() { "68108" } },
                { "timezone", new List<string>() { "-6" } },
            };
            for (var i = 1; i <= _entities; ++i)
            {
                foreach (var kvp in properties)
                {
                    context.MapMetadata.Add(new MapMetadata()
                    {
                        Id = _id++,
                        PageViewId = i,
                        Name = kvp.Key,
                        Value = kvp.Value[_rnd.Next(kvp.Value.Count)]
                    });
                }
            }
            base.Seed(context);
        }
    }
}
