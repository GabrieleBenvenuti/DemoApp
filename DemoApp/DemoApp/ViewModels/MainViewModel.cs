using DemoApp.Common;
using DemoApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IRssService rssService;

        public ObservableCollection<RssItem> Feed => rssService.Feed;

        public async override void Activate()
        {
            if (!rssService.IsLoaded)
                await rssService.LoadAsync();

            base.Activate();
        }
    }
}
