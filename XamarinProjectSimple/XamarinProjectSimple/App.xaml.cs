using Xamarin.Forms;
using XamarinProjectSimple.Views;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.Services.Authorization;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinProjectSimple
{
    public partial class App : Application
	{
        public static Application CurrentApp { get; private set; }

        public App ()
		{
            CurrentApp = this;

			InitializeComponent();

            IAuthService auth = DependencyService.Get<IAuthService>();

            if (auth.IsAuthorized) GoToRoot();

            else MainPage = new NavigationPage(new Views.Profile.ProfilePage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public static void GoToRoot()
        {
            CurrentApp.MainPage =new MainPage();
        }

    }
}
