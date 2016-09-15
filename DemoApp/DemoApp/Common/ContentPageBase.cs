using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp.Common
{
    public abstract class ContentPageBase : ContentPage
    {
        public ContentPageBase() { }

        protected override void OnAppearing()
        {
            var dataContext = this.BindingContext as INavigable;
            if (dataContext != null)
                dataContext.Activate();

            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
