using Prism.Mvvm;
using StoreAppWPF.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAppWPF.ViewModels
{
    public class GroupViewModel : BindableBase
    {
        public GroupViewModel()
        {
            this.PropertyChanged += new PropertyChangedEventHandler(OnNotifiedOfPropertyChanged);
        }

        private void OnNotifiedOfPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e != null && !String.Equals(e.PropertyName, "IsChanged", StringComparison.Ordinal))
            {
                
            }
        }
        void Add()
        {

        }
    }
}
