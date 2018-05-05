using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DisplayPlatformInfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayPlatformInfoPage : ContentPage
    {
        public DisplayPlatformInfoPage()
        {
            InitializeComponent();

            IPlatformInfo platformInfo = DependencyService.Get<IPlatformInfo>(); 
            modelLabel.Text = platformInfo.GetModel();
            versionLabel.Text = platformInfo.GetVersion();
        }
    }
}
