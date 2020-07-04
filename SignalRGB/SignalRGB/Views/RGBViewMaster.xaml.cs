using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignalRGB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RGBViewMaster : ContentPage
    {
        public ListView ListView;

        public RGBViewMaster()
        {
            InitializeComponent();

            BindingContext = new RGBViewMasterViewModel();
            ListView = MenuItemsListView;
        }

        class RGBViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<RGBViewMasterMenuItem> MenuItems { get; set; }

            public RGBViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<RGBViewMasterMenuItem>(new[]
                {
                    new RGBViewMasterMenuItem { Id = 0, Title = "Page 1" },
                    new RGBViewMasterMenuItem { Id = 1, Title = "Page 2" },
                    new RGBViewMasterMenuItem { Id = 2, Title = "Page 3" },
                    new RGBViewMasterMenuItem { Id = 3, Title = "Page 4" },
                    new RGBViewMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}