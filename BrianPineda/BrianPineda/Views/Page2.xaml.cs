using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrianPineda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listemple.ItemsSource = await App.DBContactos.listarcontactos(); 

        }
        private async void Tooladd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void Listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void Toolmap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageMap());
        }
    }
}