using DemoApp.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Services
{
    public class DemoRssService : IRssService
    {
        public bool IsLoaded => true;
        public ObservableCollection<RssItem> Feed => new ObservableCollection<RssItem>();
        public Task LoadAsync() => Task.FromResult<object>(null);

        public DemoRssService()
        {
            Feed.Add(new RssItem
            {
                Title = "Primo feed",
                Date = DateTime.Now,
                Url = "url1"
            });

            Feed.Add(new RssItem
            {
                Title = "Secondo feed",
                Date = DateTime.Now.AddDays(-1),
                Url = "url2"
            });
        }
    }
}
