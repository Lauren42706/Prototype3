﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParentHomePage : ContentPage
    {
        public ParentHomePage()
        {
            InitializeComponent();
        }

        private async void Settings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

    }
}