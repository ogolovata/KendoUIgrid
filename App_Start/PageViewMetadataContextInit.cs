using System.Collections.Generic;
using System.Data.Entity;
using KendoUIgrid.Models;
using System;

namespace KendoUIgrid.App_Start
{
    public class PageViewMetadataContextInit : DropCreateDatabaseAlways<PageViewMetadataContext>
    {
        private int _entities = 3;
        private int _id = 1;
        private Random _rnd = new Random();

        public PageViewMetadataContextInit(int entities)
        {
            _entities = entities;
        }
        protected override void Seed(PageViewMetadataContext context)
        {
            var properties = new Dictionary<string, List<string>>()
            { 
                { "Scroll -1", new List<string>(){ "0", "2", "5", "10" } },
                { "Scroll 25%", new List<string>() { "0", "2", "5", "10" } },
                { "Scroll 50%", new List<string>() { "0", "2", "5", "10" } },
                { "Link click", new List<string>() { "0", "2", "5", "10"} },
                { "Load video", new List<string>() { "0", "2", "5", "10"} },
                { "Rating", new List<string>() { "0", "2", "5", "10"} },
            };
            for (var i = 1; i <= _entities; ++i)
            {
                foreach (var kvp in properties)
                {
                    context.PageViewMetadata.Add(new PageViewMetadata()
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
