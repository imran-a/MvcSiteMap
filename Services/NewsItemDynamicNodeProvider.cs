using MvcSiteMapProvider.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSiteMap.Services
{
    public class NewsItemDynamicNodeProvider : DynamicNodeProviderBase
    {
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection()
        {
            var returnValue = new List<DynamicNode>();

            // fix for not being about to get ninject to worj with DynamicNodeProviderBase
            var newsItemService = DependencyResolver.Current.GetService<INewsItemService>();

            foreach (var item in newsItemService.GetAll())
            {
                DynamicNode node = new DynamicNode();
                node.Title = item.Title;
                node.Action = "detail";
                node.RouteValues.Add("url", item.Url);
                returnValue.Add(node);
            }

            return returnValue;
        }
    }
}