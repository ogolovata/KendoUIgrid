using System.Collections.Generic;
using System.Data.Entity;
using KendoUIgrid.Models;
using System;

namespace KendoUIgrid.App_Start
{
    public class EventMetadataContextInit : DropCreateDatabaseAlways<EventMetadataContext>
    {
        private Random _rnd = new Random();
        private int _entities = 3;
        private int _id = 1;

        public EventMetadataContextInit(int entities)
        {
            _entities = entities;
        }
        protected override void Seed(EventMetadataContext context)
        {
            var activityTypes = new List<string>() {
                "Page Authoring",
                "Survey",
                "Disqus",
                "Contribution",
                "Rating Verbatim",
                "Revision",
                "AnchorTagClick",
                "ImgTagClick",
                "AreaTagClick",
                "InputTagClick",
                "MsomCustomEvent",
                    };
            for (var i = 1; i <= _entities; ++i)
            {
                var events = _rnd.Next(10) + 1;
                for (var j = 1; j < events; ++j)
                {
                    context.EventMetadata.Add(new EventMetadata()
                    {
                        EventId = _id++,
                        PageViewId = i,
                        EventDateTime = DateTime.Now.AddMilliseconds(-_rnd.Next(24*60*60*1000)).ToString(),
                        ActivityType = activityTypes[_rnd.Next(activityTypes.Count)]
                    });
                }
            }
            base.Seed(context);
        }
    }
}
