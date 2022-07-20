using Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlogComHome : ContentPage
    {

        // Launcher.OpenAsync is provided by Xamarin.Essentials.
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public BlogComHome()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void PodcastsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Podcasts());
        }

        private async void VlogsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vlogs());
        }
    }
}