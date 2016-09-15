using DemoApp.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Services
{
    interface IRssService
    {
        bool IsLoaded { get; }
        ObservableCollection<RssItem> Feed { get; }
        Task LoadAsync();
    }
}
