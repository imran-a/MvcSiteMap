using MvcSiteMap.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSiteMap.Controllers
{
    public class NewsController : Controller
    {

        INewsItemService newsItemService;

        public NewsController(INewsItemService newsItem)
        {
            newsItemService = newsItem;
        }

        public ActionResult Index()
        {
            var items = newsItemService.GetAll();

            foreach (var item in items)
                item.Url = "/news/" + item.Url;

            return View(items);
        }

        public ActionResult Detail(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                var item = newsItemService.Get(url);
                if (item != null)
                {
                    return View(item);
                }
            }

            return new EmptyResult();
        }
    }
}
