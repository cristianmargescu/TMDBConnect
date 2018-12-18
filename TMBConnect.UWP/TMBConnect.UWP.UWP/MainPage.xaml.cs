using Xamarin.Forms;

namespace TMBConnect.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new Application());
        }
    }
}
