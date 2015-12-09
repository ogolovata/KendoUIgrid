using System.Collections.Generic;
using System.Data.Entity;
using KendoUIgrid.Models;
using System;

namespace KendoUIgrid.App_Start
{
    public class UserMetadataContextInit : DropCreateDatabaseAlways<UserMetadataContext>
    {
        private int _entities = 3;
        private int _id = 1;
        private Random _rnd = new Random();

        public UserMetadataContextInit(int entities)
        {
            _entities = entities;
        }
        protected override void Seed(UserMetadataContext context)
        {
            var properties = new Dictionary<string, List<string>>()
            { 
                { "SiteLocale", new List<string>(){ "JP", "UK", "US" } },
                { "OS", new List<string>() { "Microsoft Windows", "Linux2", "OS X", "iOS" } },
                { "Browser", new List<string>() { "IE/Microsoft Edge", "Google Chrome", "Firefoxt", "Opera", "Safari" } },
                { "BrowserLanguage", new List<string>() { "JP", "EN"} },
            };
            for (var i = 1; i <= _entities; ++i)
            {
                foreach (var kvp in properties)
                {
                    context.UserMetadata.Add(new UserMetadata()
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
