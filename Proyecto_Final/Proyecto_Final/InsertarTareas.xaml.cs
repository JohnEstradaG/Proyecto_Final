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
	public partial class InsertarTareas : ContentPage
	{
		public InsertarTareas ()
		{
			InitializeComponent ();
		}

        private async void Insert_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Correos.Text)) {

               await DisplayAlert("Importante","Debe de Ingresar Un Correo De un Usuario Existente","OK");
            }
            else {
                if (string.IsNullOrEmpty(Tarea.Text))
                {

                   await DisplayAlert("Importante", "Debe de Ingresar Un Tarea", "OK");
                }
                else
                {
                    if (string.IsNullOrEmpty(Estatus.Text))
                    {

                       await DisplayAlert("Importante", "Debe de Ingresar Un Estatus", "OK");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(Descripcion.Text))
                        {

                            await DisplayAlert("Importante", "Debe de Ingresar Un Descripcion de la Tarea", "OK");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(Prioridad.Text))
                            {

                               await DisplayAlert("Importante", "Debe de Ingresar la prioridad de la tareas", "OK");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(Dependencia.Text))
                                {

                                   await DisplayAlert("Importante", "Debe de Ingresar Un Dependencia de la tarea", "OK");
                                }
                                else
                                {
                                    if (Estatus.Text=="true")
                                    {
                                        if (Correos.Text.Contains("@hotmail.com"))
                                        {
                                            try
                                            {
                                                var datos = new TareasJohn
                                                {
                                                    Correos = Correos.Text,
                                                    Tarea = Tarea.Text,
                                                    Estatus = true,
                                                    Descripcion = Descripcion.Text,
                                                    Prioridad = Prioridad.Text,
                                                    Fecha = Fecha.Date,
                                                    Dependencia = Convert.ToInt32(Dependencia.Text),

                                                };
                                                await MainPage.Tablet.InsertAsync(datos);
                                                await Navigation.PopAsync();
                                            }
                                            catch (Exception ex)
                                            {

                                                await DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                            }

                                        }
                                        else {
                                            if (Correos.Text.Contains("@gmail.com"))
                                            {
                                                try
                                                {
                                                    var datos = new TareasJohn
                                                    {
                                                        Correos = Correos.Text,
                                                        Tarea = Tarea.Text,
                                                        Estatus = true,
                                                        Descripcion = Descripcion.Text,
                                                        Prioridad = Prioridad.Text,
                                                        Fecha = Fecha.Date,
                                                        Dependencia = Convert.ToInt32(Dependencia.Text),

                                                    };
                                                    await MainPage.Tablet.InsertAsync(datos);
                                                    await Navigation.PopAsync();
                                                }
                                                catch (Exception ex)
                                                {

                                                    await DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                                }

                                            }
                                            else
                                            {
                                                if (Correos.Text.Contains("@outlook.com"))
                                                {
                                                    try
                                                    {
                                                        var datos = new TareasJohn
                                                        {
                                                            Correos = Correos.Text,
                                                            Tarea = Tarea.Text,
                                                            Estatus = true,
                                                            Descripcion = Descripcion.Text,
                                                            Prioridad = Prioridad.Text,
                                                            Fecha = Fecha.Date,
                                                            Dependencia = Convert.ToInt32(Dependencia.Text),

                                                        };
                                                        await MainPage.Tablet.InsertAsync(datos);
                                                        await Navigation.PopAsync();
                                                    }
                                                    catch (Exception ex)
                                                    {

                                                        await DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                                    }

                                                }
                                                else
                                                {
                                                    await DisplayAlert("Importante", "Su Correo debe de contener \n@hotmail.com \n@outlook.com \n@gmail.com", "Ok");

                                                }

                                            }

                                        }

                                    }
                                    else
                                    {
                                        if (Estatus.Text == "false" ) {
                                            if (Correos.Text.Contains("@hotmail.com"))
                                            {
                                                try
                                                {
                                                    var datos = new TareasJohn
                                                    {
                                                        Correos = Correos.Text,
                                                        Tarea = Tarea.Text,
                                                        Estatus = false,
                                                        Descripcion = Descripcion.Text,
                                                        Prioridad = Prioridad.Text,
                                                        Fecha = Fecha.Date,
                                                        Dependencia = Convert.ToInt32(Dependencia.Text),

                                                    };
                                                    await MainPage.Tablet.InsertAsync(datos);
                                                    await Navigation.PopAsync();
                                                }
                                                catch (Exception ex)
                                                {

                                                    await DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                                }

                                            }
                                            else
                                            {
                                                if (Correos.Text.Contains("@gmail.com"))
                                                {
                                                    try
                                                    {
                                                        var datos = new TareasJohn
                                                        {
                                                            Correos = Correos.Text,
                                                            Tarea = Tarea.Text,
                                                            Estatus = false,
                                                            Descripcion = Descripcion.Text,
                                                            Prioridad = Prioridad.Text,
                                                            Fecha = Fecha.Date,
                                                            Dependencia = Convert.ToInt32(Dependencia.Text),

                                                        };
                                                        await MainPage.Tablet.InsertAsync(datos);
                                                        await Navigation.PopAsync();
                                                    }
                                                    catch (Exception ex)
                                                    {

                                                        await DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                                    }

                                                }
                                                else
                                                {
                                                    if (Correos.Text.Contains("@outlook.com"))
                                                    {
                                                        try
                                                        {
                                                            var datos = new TareasJohn
                                                            {
                                                                Correos = Correos.Text,
                                                                Tarea = Tarea.Text,
                                                                Estatus = false,
                                                                Descripcion = Descripcion.Text,
                                                                Prioridad = Prioridad.Text,
                                                                Fecha = Fecha.Date,
                                                                Dependencia = Convert.ToInt32(Dependencia.Text),

                                                            };
                                                            await MainPage.Tablet.InsertAsync(datos);
                                                            await Navigation.PopAsync();
                                                        }
                                                        catch (Exception ex)
                                                        {

                                                            await DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                                        }

                                                    }
                                                    else
                                                    {
                                                        await DisplayAlert("Importante", "Su Correo debe de contener \n@hotmail.com \n@outlook.com \n@gmail.com", "Ok");

                                                    }

                                                }

                                            }
                                        }
                                        else {

                                            await DisplayAlert("Importante","El Estatus Debe solo ser:\ntrue: Para dar de alta la tarea \nfalse: Para dar de baja la tarea","OK");

                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}