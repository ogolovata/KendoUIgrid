using System.Collections.Generic;
using System.Data.Entity;
using KendoUIgrid.Models;
using System;

namespace KendoUIgrid.App_Start
{
    public class VisitMetadataContextInit : DropCreateDatabaseAlways<VisitMetadataContext>
    {
        private int _entities = 3;
        private int _id = 1;
        private Random _rnd = new Random();

        public VisitMetadataContextInit(int entities)
        {
            _entities = entities;
        }
        protected override void Seed(VisitMetadataContext context)
        {
            var properties = new Dictionary<string, List<string>>()
            { 
                { "V-property1", new List<string>(){ "A", "B", "C" } },
                { "V-property2", new List<string>() { "AA", "BB", "CC" } },
                { "V-property3", new List<string>() { "AAA", "BBB", "CCC" } },
            };
            for (var i = 1; i <= _entities; ++i)
            {
                foreach (var kvp in properties)
                {
                    context.VisitMetadata.Add(new VisitMetadata()
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
