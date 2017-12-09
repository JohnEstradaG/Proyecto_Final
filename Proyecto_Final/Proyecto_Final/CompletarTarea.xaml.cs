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
	public partial class CompletarTarea : ContentPage
	{
        public static string UsuarioLocal;
        public static string PasswordLocal;
        public CompletarTarea (object SelectedItem, string Usuario, string Contraseña)
		{
            UsuarioLocal = Usuario.ToString(); ;
            PasswordLocal = Contraseña.ToString();

            var dato = SelectedItem as TareasJohn;
            BindingContext = dato;
            InitializeComponent ();
            Users();
		}

        private async void Update_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Correos.Text))
            {

                await DisplayAlert("Importante", "Debe de Ingresar Un Correo De un Usuario Existente", "OK");
            }
            else
            {
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
                                    if (Estatus.Text == "true")
                                    {
                                        if (Correos.Text.Contains("@hotmail.com"))
                                        {
                                            try
                                            {
                                                var datos = new TareasJohn
                                                {
                                                    Id = Id.Text,
                                                    Correos = Correos.Text,
                                                    Tarea = Tarea.Text,
                                                    Estatus = true,
                                                    Descripcion = Descripcion.Text,
                                                    Prioridad = Prioridad.Text,
                                                    Fecha = Fecha.Date,
                                                    Dependencia = Convert.ToInt32(Dependencia.Text),

                                                };
                                                await MainPage.Tablet.UpdateAsync(datos);
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
                                                var datos = new TareasJohn
                                                {
                                                    Id = Id.Text,
                                                    Correos = Correos.Text,
                                                    Tarea = Tarea.Text,
                                                    Estatus = true,
                                                    Descripcion = Descripcion.Text,
                                                    Prioridad = Prioridad.Text,
                                                    Fecha = Fecha.Date,
                                                    Dependencia = Convert.ToInt32(Dependencia.Text),

                                                };
                                                await MainPage.Tablet.UpdateAsync(datos);
                                                await Navigation.PopAsync();
                                            }
                                            else
                                            {
                                                if (Correos.Text.Contains("@outlook.com"))
                                                {
                                                    var datos = new TareasJohn
                                                    {
                                                        Id = Id.Text,
                                                        Correos = Correos.Text,
                                                        Tarea = Tarea.Text,
                                                        Estatus = true,
                                                        Descripcion = Descripcion.Text,
                                                        Prioridad = Prioridad.Text,
                                                        Fecha = Fecha.Date,
                                                        Dependencia = Convert.ToInt32(Dependencia.Text),
                                                    };
                                                    await MainPage.Tablet.UpdateAsync(datos);
                                                    await Navigation.PopAsync();
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
                                        if (Estatus.Text == "false")
                                        {
                                            if (Correos.Text.Contains("@hotmail.com"))
                                            {
                                                var datos = new TareasJohn
                                                {
                                                    Id = Id.Text,
                                                    Correos = Correos.Text,
                                                    Tarea = Tarea.Text,
                                                    Estatus = true,
                                                    Descripcion = Descripcion.Text,
                                                    Prioridad = Prioridad.Text,
                                                    Fecha = Fecha.Date,
                                                    Dependencia = Convert.ToInt32(Dependencia.Text),
                                                };
                                                await MainPage.Tablet.UpdateAsync(datos);
                                                await Navigation.PopAsync();
                                            }
                                            else
                                            {
                                                if (Correos.Text.Contains("@gmail.com"))
                                                {
                                                    var datos = new TareasJohn
                                                    {
                                                        Id = Id.Text,
                                                        Correos = Correos.Text,
                                                        Tarea = Tarea.Text,
                                                        Estatus = true,
                                                        Descripcion = Descripcion.Text,
                                                        Prioridad = Prioridad.Text,
                                                        Fecha = Fecha.Date,
                                                        Dependencia = Convert.ToInt32(Dependencia.Text),
                                                    };
                                                    await MainPage.Tablet.UpdateAsync(datos);
                                                    await Navigation.PopAsync();
                                                }
                                                else
                                                {
                                                    if (Correos.Text.Contains("@outlook.com"))
                                                    {
                                                        var datos = new TareasJohn
                                                        {
                                                            Id = Id.Text,
                                                            Correos = Correos.Text,
                                                            Tarea = Tarea.Text,
                                                            Estatus = true,
                                                            Descripcion = Descripcion.Text,
                                                            Prioridad = Prioridad.Text,
                                                            Fecha = Fecha.Date,
                                                            Dependencia = Convert.ToInt32(Dependencia.Text),
                                                        };
                                                        await MainPage.Tablet.UpdateAsync(datos);
                                                        await Navigation.PopAsync();
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

                                            await DisplayAlert("Importante", "El Estatus Debe solo ser:\ntrue: Para dar de alta la tarea \nfalse: Para dar de baja la tarea", "OK");

                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            try
            {
                var datos = new TareasJohn
                {
                    Id = Id.Text,
                    Estatus = false,
                };
                await MainPage.Tablet.UpdateAsync(datos);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {

                await DisplayAlert("Importante", "No se encontro el usuario o ya esta eliminado", "Ok");

            }
        }

        private void Insertar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertarTareas());
        }

        private async void Users()
        {
            IEnumerable<_13090353> Users = await Proyecto_Final.MainPage.Table.Where(_13090353 => _13090353.Correo == UsuarioLocal.ToString() && _13090353.Contraseña == PasswordLocal.ToString()).ToEnumerableAsync();
            foreach (var x in Users)
            {
                if (x.TipoUsuario == 1)
                {
                    Update.IsEnabled = true;
                    Update.IsVisible = true;
                    Delete.IsEnabled = true;
                    Delete.IsVisible = true;
                    Insertar.IsEnabled = true;
                    Insertar.IsVisible = true;
                    Tarea.IsEnabled = true;
                    Estatus.IsEnabled = true;
                    Descripcion.IsEnabled = true;
                    Prioridad.IsEnabled = true;
                    Fecha.IsEnabled = true;
                    Dependencia.IsEnabled = true;
                }
                else
                {
                    Delete.IsEnabled = true;
                    Delete.IsVisible = true;
                }
            }
        }
    }
}