using System.Collections.Generic;
using System.Data.Entity;
using KendoUIgrid.Models;
using System;

namespace KendoUIgrid.App_Start
{
    public class IssueMetadataContextInit : DropCreateDatabaseAlways<IssueMetadataContext>
    {
        private int _entities = 3;
        private int _id = 1;
        private Random _rnd = new Random();

        public IssueMetadataContextInit(int entities)
        {
            _entities = entities;
        }
        protected override void Seed(IssueMetadataContext context)
        {
            var properties = new Dictionary<string, List<string>>()
            { 
                { "I-property1", new List<string>(){ "a", "aa", "aaa" } },
                { "I-property2", new List<string>() { "b", "bb", "bbb", "bbbb" } },
                { "I-property3", new List<string>() { "c", "cc", "ccc", "cccc", "ccccc" } },
                { "I-property4", new List<string>() { "d", "dd"} },
            };
            for (var i = 1; i <= _entities; ++i)
            {
                foreach (var kvp in properties)
                {
                    context.IssueMetadata.Add(new IssueMetadata()
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
