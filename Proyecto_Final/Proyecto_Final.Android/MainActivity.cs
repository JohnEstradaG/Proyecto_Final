using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Proyecto_Final.Droid
{
    [Activity(Label = "Proyecto_Final", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity,SQLAzure
    {
        private MobileServiceUser usuario;

        public async Task<MobileServiceUser> Authenticate()
        {
            var message = string.Empty;
            try
            {
                usuario = await Proyecto_Final.MainPage.cliente.LoginAsync(this, MobileServiceAuthenticationProvider.MicrosoftAccount, "tesh.azurewebsites.net");
                if (usuario != null)
                {
                    //message = string.Format("Usuario Autenticado {0}.", usuario.UserId);
                    //await new MessageDialog(usuario.UserId, "Bienvenido").ShowAsync();
                }
            }
            catch (Exception ex)
            {

                message = ex.Message;
            }
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.SetMessage(message);
            builder.SetTitle("Resultado de autenticacion");
            builder.Create().Show();
            return usuario;
        }
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            App.Init((SQLAzure)this);
            LoadApplication(new App());
        }
    }
}

