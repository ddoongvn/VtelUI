using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace VtelUI.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Switcher.SelectedIndex = 4;
            var safeInsets = On<iOS>().SafeAreaInsets();
            safeInsets.Top = 0;
            
        }


        private void TabButton_Clicked(object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Switcher.SelectedIndex = 4;
            });
           
        }     
    }
}