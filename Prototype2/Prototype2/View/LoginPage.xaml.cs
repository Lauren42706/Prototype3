using Prototype2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prototype2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoginClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        /*   private async void CreateAccountClicked(object sender, EventArgs e)
           {
               await Navigation.PushAsync(new CreateAccountPage());
           }  */

        private async void CreateAccountClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BlogComHome());
        }

        private async void ForgotPasswordClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StoryStartPage());
        }
    }
}
