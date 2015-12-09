using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KendoUIgrid.Models
{
    public class EventMetadata
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }
        // parent pageview id
        public int PageViewId { get; set;}
        public string ActivityType { get; set; }
        public string EventDateTime { get; set; }
    }
}