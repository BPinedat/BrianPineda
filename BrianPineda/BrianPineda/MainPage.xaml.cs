using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BrianPineda
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private  async void Btnsalvar_Clicked(object sender, EventArgs e)
        {
            var contac = new Moldes.Contactos
            {
                Nombres = txtnombre.Text,
                Apellidos = txtapellido.Text,
                Edad = Convert.ToInt32(txtedad.Text),
                Telefono = Convert.ToInt32(txttelefono.Text),
                Pais = Pais.SelectedItem as string, 
                Nota = txtnota.Text
            };

            if (await App.DBContactos.Storecontac(contac) > 0)
                await DisplayAlert("Aviso", "Registro ingresado con exito", "ok");
            

        }
    }
}
