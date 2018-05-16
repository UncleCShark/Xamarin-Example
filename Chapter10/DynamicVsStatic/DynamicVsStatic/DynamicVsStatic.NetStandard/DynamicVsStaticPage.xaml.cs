using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace DynamicVsStatic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicVsStaticPage : ContentPage
    {
        public DynamicVsStaticPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1),
                () =>
                {
                    Resources["currentDateTime"] = DateTime.Now.ToString();
                    return true;
                });
        }
    }
}

