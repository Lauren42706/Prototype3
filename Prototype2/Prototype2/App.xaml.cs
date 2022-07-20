//using Prototype2.Services;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype2
{
    public partial class App : Application
    {
        /// <summary>
        /// We will put or Database code here so that it 
        /// is accessible throughout the app.
        /// </summary>
        //private static Database database;
        //public static Database Database
        //{
        //    get
        //    {
        //        if(database == null)
        //        {
        //            database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "user.db3"));
        //        }

        //        return database;
        //    }
        //}

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
