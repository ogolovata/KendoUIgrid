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
                { "User_Browser", new List<string>(){ "IE" } },
                { "User_Country", new List<string>() { "united states" } },
                { "MaxScroll", new List<string>() { "0" } },
                { "PageLocale", new List<string>() { "en-us" }},
                { "MatchLanguage", new List<string>() { "True", "False" }},
                { "BrowserLanguage", new List<string>() { "en-us" }},
                { "User_Device", new List<string>() { "PC" }},
                { "FeedbackResponse", new List<string>() { "" }},
                { "User_OS", new List<string>() { "Windows 10" }},
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
