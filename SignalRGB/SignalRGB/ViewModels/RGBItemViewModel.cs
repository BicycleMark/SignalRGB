using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using SignalRGB.Models;
using SignalRGB.Views;

namespace SignalRGB.ViewModels
{
    public class RGBItemViewModel : BaseViewModel
    {

        RGBItem RGBItem;
        public Command LoadItemsCommand { get; set; }

        public RGBItemViewModel()
        {
            
            RGBItem = new RGBItem();
            //LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }

        async Task ExecuteLoadItemsCommand()
        {
           // IsBusy = true;

            //try
            //{
            //    Items.Clear();
            //    var items = await DataStore.GetItemsAsync(true);
            //    foreach (var item in items)
            //    {
            //        Items.Add(item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(ex);
            //}
            //finally
            //{
            //    IsBusy = false;
            //}
        }
    }
}