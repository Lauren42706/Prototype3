using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DummyPage : ContentPage
    {
        public DummyPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetUserDataAsync();
        }
    }
}