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
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private async void SignUpClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(firstNameEntry.Text) && !string.IsNullOrWhiteSpace(lastNameEntry.Text)
                && !string.IsNullOrWhiteSpace(emailEntry.Text) && !string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                await App.Database.SaveUserDataAsync(new Model.UserData
                {
                    FirstName = firstNameEntry.Text,
                    LastName = lastNameEntry.Text,
                    EmailAddress = emailEntry.Text,
                    Password = passwordEntry.Text
                });

                firstNameEntry.Text = lastNameEntry.Text = emailEntry.Text = passwordEntry.Text = string.Empty;

                await Navigation.PushAsync(new DummyPage());
            }

            if (string.IsNullOrWhiteSpace(firstNameEntry.Text) || string.IsNullOrWhiteSpace(lastNameEntry.Text)
                || string.IsNullOrWhiteSpace(emailEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                await DisplayAlert("Incomplete Form", "Not all fields have been filled!", "Okay");

                firstNameEntry.PlaceholderColor = Color.Red;
                lastNameEntry.PlaceholderColor = Color.Red;
                emailEntry.PlaceholderColor = Color.Red;
                passwordEntry.PlaceholderColor = Color.Red;
            }

            
        }
    }
}