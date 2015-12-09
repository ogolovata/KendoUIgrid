using System.Collections.Generic;
using System.Data.Entity;
using KendoUIgrid.Models;
using System;

namespace KendoUIgrid.App_Start
{
    public class ContentMetadataContextInit : DropCreateDatabaseAlways<ContentMetadataContext>
    {
        private int _entities = 3;
        private int _id = 1;
        private Random _rnd = new Random();

        public ContentMetadataContextInit(int entities)
        {
            _entities = entities;
        }

        protected override void Seed(ContentMetadataContext context)
        {
            var properties = new Dictionary<string, List<string>>()
            { 
                { "Product", new List<string>(){ "VS", "SQL", "Azure" } },
                { "Type", new List<string>() { "Conceptual", "Reference", "Hero Content" } },
                { "Author", new List<string>() { "Olena", "Tom", "Olga" } },
                { "Translation", new List<string>() { "Human", "Machine" } },
                { "Site", new List<string> { "MSDN", "ACOM", "TN" }}
            }; 
            
            for (var i = 1; i <= _entities; ++i)
            {
                foreach (var kvp in properties)
                {
                    context.ContentMetadata.Add(new ContentMetadata() 
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
