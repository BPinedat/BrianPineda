using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace BrianPineda
{
    public partial class App : Application
    {
        static Controllers.DBContactos Dbcontac;

        public static Controllers.DBContactos DBContactos
        {
            get
            {
                if (Dbcontac == null)
                {
                    String DBName = "contac.db3";
                    String PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    Dbcontac = new Controllers.DBContactos(PathDB);
                }

                return Dbcontac;
            }

        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Page2());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
