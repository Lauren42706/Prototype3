using Prism;
using Prototype2.Services;
using Prototype2.ViewModel;
using Prototype2.View;
using Prototype2.Services.Interfaces;
using Prototype2.View.Dialogs;
using Xamarin.Forms;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms.Xaml;

namespace Prototype2
{
    public partial class App 
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

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {

        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IAuthentication, AuthenticationServices>();

            containerRegistry.RegisterSingleton<IDataCache, InMemoryDataCache>();

            containerRegistry.Register<IAppConfiguration, AppConfigurationServices>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, LoginViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfileViewModel>();
            containerRegistry.RegisterForNavigation<ParentHomePage, ParentViewModel>();
            containerRegistry.RegisterForNavigation<ChildHomePage, ChildViewModel>();
        }
    }
}
