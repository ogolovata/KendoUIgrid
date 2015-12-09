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
                { "M-property1", new List<string>(){ "X", "Y", "Z" } },
                { "M-property2", new List<string>() { "XX", "YY", "ZZ" } },
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
