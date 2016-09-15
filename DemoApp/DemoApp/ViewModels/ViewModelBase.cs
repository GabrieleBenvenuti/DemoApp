using DemoApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.ViewModels
{
    public class ViewModelBase : GalaSoft.MvvmLight.ViewModelBase, INavigable
    {
        public ViewModelBase() { }

        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set { this.Set(ref isBusy, value, broadcast: true); }
        }

        public virtual void Activate() { }
        public virtual void Deactivate() { }
    }
}
