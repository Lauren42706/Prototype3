using Prototype2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Community
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Podcasts : ContentPage
    {
        // Launcher.OpenAsync is provided by Xamarin.Essentials.
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public Podcasts()
        {
            InitializeComponent();
            BindingContext = this;
        }

        async void BlogsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BlogComHome());
        }

        async void VlogsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(page: new Vlogs());
        }

        private async void PodcastsClicked(object sender, EventArgs e) { }
    }
}