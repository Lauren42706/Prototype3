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
    public partial class Vlogs : ContentPage
    {

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public Vlogs()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void PodcastsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Podcasts());
        }

        private async void BlogsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BlogComHome());
        }

        private async void VlogsClicked(object sender, EventArgs e) { }
    }
}