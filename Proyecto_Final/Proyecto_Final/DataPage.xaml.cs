using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataPage : ContentPage
	{
		public DataPage ()
		{
			InitializeComponent ();
		}

        private void Logear_Clicked(object sender, EventArgs e)
        {
            loggear();            
        }

        public async void loggear()
        {

            if (string.IsNullOrEmpty(Usuario.Text))
            {
                await DisplayAlert("Importante", "Debe de Ingresar un Usuario", "Ok");
            }
            else
            {
                if (string.IsNullOrEmpty(Contraseña.Text))
                {
                    await DisplayAlert("Importante", "Debe de Ingresar su contraseña", "Ok");
                }
                else
                {
                    if (Usuario.Text.Contains("@hotmail.com"))
                    {
                        await Navigation.PushAsync(new MainPage(Usuario.Text, Contraseña.Text));
                        Usuario.IsVisible = false;
                        Contraseña.IsVisible = false;
                        Logear.IsVisible = false;
                    }
                    else
                    {
                        if ( Usuario.Text.Contains("@gmail.com"))
                        {
                            await Navigation.PushAsync(new MainPage(Usuario.Text, Contraseña.Text));
                            Usuario.IsVisible = false;
                            Contraseña.IsVisible = false;
                            Logear.IsVisible = false;
                        }
                        else
                        {
                            if (Usuario.Text.Contains("@outlook.com"))
                            {
                                await Navigation.PushAsync(new MainPage(Usuario.Text, Contraseña.Text));
                                Usuario.IsVisible = false;
                                Contraseña.IsVisible = false;
                                Logear.IsVisible = false;
                            }
                            else
                            {
                                await DisplayAlert("Importante", "Su Correo es Incorrecto debe de contener \n@hotmail.com \n@outlook.com \n@gmail.com", "Ok");
                                Contraseña.Text = "";
                                Usuario.Text = "";
                            }
                        }

                    }
                }
            }
        }
    }
}