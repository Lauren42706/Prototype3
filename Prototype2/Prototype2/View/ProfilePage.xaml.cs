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
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void ParentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ParentHomePage());
        }
        private async void ChildClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChildHomePage());
        }
    }
}