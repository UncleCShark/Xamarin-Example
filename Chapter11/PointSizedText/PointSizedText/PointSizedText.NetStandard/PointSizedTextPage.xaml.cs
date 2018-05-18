using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PointSizedText
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PointSizedTextPage : ContentPage
    {
        public PointSizedTextPage()
        {
            // Instantiate sometehing in library so it can be used in XAML.
            var unused = new Xamarin.FormsBook.Toolkit.AltLabel();

            InitializeComponent();
        }
    }
}
