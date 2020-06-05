using Xamarin.Forms;

namespace VtelUI.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Switcher.SelectedIndex = 4;            
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