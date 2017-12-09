using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto_Final
{
    public partial class App : Application
    {
        public static SQLAzure Authenticator { get; private set; }

        public static void Init(SQLAzure authenticator)
        {

            Authenticator = authenticator;
        }

            public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Proyecto_Final.DataPage());
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
