using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediMinder.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FooPage : ContentPage
    {
        public FooPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailPage());
        }
    }
}
