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
                { "MaxScroll", new List<string>(){ "0", "2", "5", "10" } },
                { "PageViewLength", new List<string>(){ "0", "2", "5", "10" } },
                { "FeedbackRespondse", new List<string>(){ "" } },                
                { "Page Authoring", new List<string>(){ "0", "1" } },
                { "Survey", new List<string>() { "0", "1" } },
                { "Disqus", new List<string>() { "0", "2", "5", "10" } },
                { "Contribution", new List<string>() { "0", "1"} },
                { "Rating Verbatim", new List<string>() { "0", "1"} },
                { "Revision", new List<string>() { "0", "1"} },
                { "AnchorTagClick", new List<string>() { "0", "1"} },
                { "ImgTagClick", new List<string>() { "0", "2", "5", "10"} },
                { "AreaTagClick", new List<string>() { "0", "2", "5", "10"} },
                { "InputTagClick", new List<string>() { "0", "2", "5", "10"} },
                { "MsomCustomEvent", new List<string>() { "0", "2", "5", "10"} },
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
