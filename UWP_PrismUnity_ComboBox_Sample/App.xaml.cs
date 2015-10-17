using Prism.Unity.Windows;
using System.Threading.Tasks;
using UWP_PrismUnity_ComboBox_Sample.Services;
using Windows.ApplicationModel.Activation;


namespace UWP_PrismUnity_ComboBox_Sample
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : PrismUnityApplication
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate("Main", null);
            return Task.FromResult<object>(null);
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            RegisterTypeIfMissing(typeof(IDataRepository), typeof(DataRepository), true);
        }
    }
}
