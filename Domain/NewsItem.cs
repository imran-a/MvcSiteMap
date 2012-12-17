using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSiteMap.Domain
{
    public partial class NewsItem
    {
        public int NewsItemId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string FeatureImageRef { get; set; }
        public string ThumbImageRef { get; set; }
        public System.DateTime PublicationDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public bool IsFeatured { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateAmended { get; set; }
    }
}