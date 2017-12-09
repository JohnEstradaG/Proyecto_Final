﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UpdatePage : ContentPage
	{
        public static string UsuarioLocal;
        public static string PasswordLocal;
        public UpdatePage (object SelectedItem,string Usuario,string Contraseña)
		{
            UsuarioLocal = Usuario.ToString(); ;
            PasswordLocal = Contraseña.ToString();

            var dato = SelectedItem as _13090353;
            BindingContext = dato;
            InitializeComponent ();
            Users();
		}

        private async void Update_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre.Text))
            {
                await DisplayAlert("Importante", "Ingresa Tu Nombre", "Ok");
            }
            else
            {
                if (string.IsNullOrEmpty(Ape_pat.Text))
                {
                    await DisplayAlert("Importante", "Ingresa Tu Apellido Paterno", "Ok");
                }
                else
                {
                    if (string.IsNullOrEmpty(Ape_mat.Text))
                    {
                        await DisplayAlert("Importante", "Ingresa Tu Apellido Materno", "Ok");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(Direccion.Text))
                        {
                            await DisplayAlert("Importante", "Ingresa Tu Direccion", "Ok");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(Telefono.Text))
                            {
                                await DisplayAlert("Importante", "Ingresa Tu Numero de Telefono", "Ok");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(Carrera.Text))
                                {
                                    await DisplayAlert("Importante", "Ingresa Tu Carrera", "Ok");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(Semestre.Text))
                                    {
                                        await DisplayAlert("Importante", "Ingresa Tu Semestre", "Ok");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(Correo.Text))
                                        {
                                            await DisplayAlert("Importante", "Ingresa Tu Correo", "Ok");
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(Github.Text))
                                            {
                                                await DisplayAlert("Importante", "Ingresa Tu Github", "Ok");
                                            }
                                            else
                                            {
                                                if (Telefono.Text.Length == 10)
                                                {

                                                    if (Correo.Text.Contains("@hotmail.com"))
                                                    {
                                                        try
                                                        {
                                                            var datos = new _13090353
                                                            {
                                                                Matricula = Matricula.Text,
                                                                Nombre = Nombre.Text,
                                                                ApellidoPaterno = Ape_pat.Text,
                                                                ApellidoMaterno = Ape_mat.Text,
                                                                Direccion = Direccion.Text,
                                                                Telefono = Telefono.Text,
                                                                Carrera = Carrera.Text,
                                                                Semestre = Semestre.Text,
                                                                Correo = Correo.Text,
                                                                Github = Github.Text,
                                                                Contraseña = Contraseña.Text,
                                                                TipoUsuario = Convert.ToInt32(Tipo_Usuario.Text)
                                                            };
                                                            await MainPage.Table.UpdateAsync(datos);
                                                            await Navigation.PopAsync();
                                                        }
                                                        catch (Exception ex)
                                                        {

                                                            await DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                                        }
                                                    }
                                                    else
                                                    {

                                                        if (Correo.Text.Contains("@gmail.com"))
                                                        {
                                                            try
                                                            {
                                                                var datos = new _13090353
                                                                {
                                                                    Matricula = Matricula.Text,
                                                                    Nombre = Nombre.Text,
                                                                    ApellidoPaterno = Ape_pat.Text,
                                                                    ApellidoMaterno = Ape_mat.Text,
                                                                    Direccion = Direccion.Text,
                                                                    Telefono = Telefono.Text,
                                                                    Carrera = Carrera.Text,
                                                                    Semestre = Semestre.Text,
                                                                    Correo = Correo.Text,
                                                                    Github = Github.Text,
                                                                    Contraseña = Contraseña.Text,
                                                                    TipoUsuario = Convert.ToInt32(Tipo_Usuario.Text)
                                                                };
                                                                await MainPage.Table.UpdateAsync(datos);
                                                                await Navigation.PopAsync();
                                                            }
                                                            catch (Exception ex)
                                                            {

                                                                await DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (Correo.Text.Contains("@outlook.com"))
                                                            {
                                                                try
                                                                {
                                                                    var datos = new _13090353
                                                                    {
                                                                        Matricula = Matricula.Text,
                                                                        Nombre = Nombre.Text,
                                                                        ApellidoPaterno = Ape_pat.Text,
                                                                        ApellidoMaterno = Ape_mat.Text,
                                                                        Direccion = Direccion.Text,
                                                                        Telefono = Telefono.Text,
                                                                        Carrera = Carrera.Text,
                                                                        Semestre = Semestre.Text,
                                                                        Correo = Correo.Text,
                                                                        Github = Github.Text,
                                                                        Contraseña = Contraseña.Text,
                                                                        TipoUsuario = Convert.ToInt32(Tipo_Usuario.Text)
                                                                    };
                                                                    await MainPage.Table.UpdateAsync(datos);
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
                                                    await DisplayAlert("Importante", "El numero telefonico debe tener 10 Digitos", "Ok");
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

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            try
            {
                var datos = new _13090353
                {
                    Matricula = Matricula.Text,
                };
                await MainPage.Table.DeleteAsync(datos);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {

                await DisplayAlert("Importante", "No se encontro el usuario o ya esta eliminado", "Ok");

            }
        }

        private async void Recupera_Clicked(object sender, EventArgs e)
        {
            var datos = new _13090353
            {
                Matricula = Matricula.Text,
            };
            await MainPage.Table.UndeleteAsync(datos);
            await Navigation.PopAsync();
        }

        private void Insertar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
            
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
                    Recupera.IsEnabled = true;
                    Recupera.IsVisible = true;
                    Matricula.IsEnabled = true;
                    Nombre.IsEnabled = true;
                    Ape_pat.IsEnabled = true;
                    Ape_mat.IsEnabled = true;
                    Direccion.IsEnabled = true;
                    Telefono.IsEnabled = true;
                    Carrera.IsEnabled = true;
                    Semestre.IsEnabled = true;
                    Github.IsEnabled = true;
                    Tipo_Usuario.IsEnabled = true;
                }
                else{
                    Nombre.IsEnabled = true;
                    Ape_pat.IsEnabled = true;
                    Ape_mat.IsEnabled = true;
                    Direccion.IsEnabled = true;
                    Telefono.IsEnabled = true;
                    Carrera.IsEnabled = true;
                    Semestre.IsEnabled = true;
                    Github.IsEnabled = true;
                    Update.IsEnabled = true;
                    Update.IsVisible = true;
                }
            }
        }
    }
}