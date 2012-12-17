using MvcSiteMap.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSiteMap.Services
{
    public class NewsItemService : INewsItemService
    {

        List<NewsItem> _items;

        public NewsItemService()
        {
            _items = new List<NewsItem>();
            _items.Add(new NewsItem()
            {
                Url = "one",
                Title = "news item 1"
            });

            _items.Add(new NewsItem()
            {
                Url = "two",
                Title = "news item 2"
            });

            _items.Add(new NewsItem()
            {
                Url = "three",
                Title = "news item 3"
            });
        }

        public NewsItem Get(string url)
        {
            return _items.Where(n => n.Url.ToLower() == url.ToLower()).FirstOrDefault();
        }

        public IEnumerable<NewsItem> GetAll()
        {
            return _items;
        }
    }

    public interface INewsItemService
    {
        IEnumerable<NewsItem> GetAll();
        NewsItem Get(string url);

    }
}