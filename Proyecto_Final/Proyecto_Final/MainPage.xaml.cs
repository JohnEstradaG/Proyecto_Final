using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Proyecto_Final
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<_13090353> Items { get; set; }
        public ObservableCollection<TareasJohn> Itemst { get; set; }
        public static MobileServiceClient cliente;
        public static IMobileServiceTable<_13090353> Table;
        public static IMobileServiceTable<TareasJohn> Tablet;
        public static MobileServiceUser Usuario;

        public static string usuariolocal;
        public static string PasswordLocal;

        public MainPage(string usuario, string contraseña)
        {
            InitializeComponent();
            usuariolocal = usuario.ToString(); ;
            PasswordLocal = contraseña.ToString();
            cliente = new MobileServiceClient(AzureConnection.AzureUrl);
            Login();
            Table = cliente.GetTable<_13090353>();
            Tablet = cliente.GetTable<TareasJohn>();
        }

        public async void Login()
        {
            Usuario = await App.Authenticator.Authenticate();
            if (App.Authenticator != null)
            {
                if (Usuario != null)
                {
                   // await DisplayAlert("Usuario Autenticado", Usuario.UserId + Usuario.MobileServiceAuthenticationToken, "Ok");
                }
                LeerUsuario();
                LeerTareas();
                AdminOUsuario();
            }
        }

        private async void LeerUsuario()
        {

            IEnumerable<_13090353> elementos = await Table.Where(_13090353 => _13090353.Correo == usuariolocal.ToString() && _13090353.Contraseña == PasswordLocal.ToString()).ToEnumerableAsync();
            foreach (var x in elementos)
            {
                if (x.Correo == "")
                {
                    await DisplayAlert("Importante", "El Usuario No existe", "ok");
                    await Navigation.PopAsync();
                }
                else {
                    Items = new ObservableCollection<_13090353>(elementos);
                    BindingContext = this;
                    Lista.ItemsSource = Items;
                }
            }
        }

        private async void LeerEliminados()
        {
            try
            {
                IEnumerable<_13090353> elementos = await Table.IncludeDeleted().Where(_13090353 => _13090353.Deleted == true).ToEnumerableAsync();
                Items = new ObservableCollection<_13090353>(elementos);
                BindingContext = this;
                Lista.ItemsSource = Items;
                Existentes.IsEnabled = true;
                Existentes.IsVisible = true;
                Eliminados.IsEnabled = false;
                Eliminados.IsVisible = false;
                User.IsVisible = true;
                User.IsEnabled = true;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Importante", "Conexion a la base de datos no encontrada comuniquese con el servicio de azure", "ok");

            }
        }

        private async void LeerExistentes()
        {
            try
            {
                IEnumerable<_13090353> elementos = await Table.ToEnumerableAsync();
                Items = new ObservableCollection<_13090353>(elementos);
                BindingContext = this;
                Lista.ItemsSource = Items;
                Existentes.IsEnabled = false;
                Existentes.IsVisible = false;
                Eliminados.IsEnabled = true;
                Eliminados.IsVisible = true;
                User.IsVisible = true;
                User.IsEnabled = true;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Importante", "El Usuario No existe", "ok");
                await Navigation.PopAsync();
            }
        }

        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new UpdatePage(e.SelectedItem as _13090353,usuariolocal.ToString(), PasswordLocal.ToString()));
        }

        private void DB_Clicked(object sender, EventArgs e)
        {
            LeerExistentes();
        }

        private void Eliminados_Clicked(object sender, EventArgs e)
        {
            LeerEliminados();
        }

        private void User_Clicked(object sender, EventArgs e)
        {
            LeerUsuario();
            User.IsVisible = false;
            User.IsEnabled = false;
            Eliminados.IsEnabled = true;
            Eliminados.IsVisible = true;
            Existentes.IsEnabled = true;
            Existentes.IsVisible = true;
        }

        public async void AdminOUsuario()
        {

            IEnumerable<_13090353> Users = await Table.Where(_13090353 => _13090353.Correo == usuariolocal.ToString() && _13090353.Contraseña == PasswordLocal.ToString()).ToEnumerableAsync();
            foreach (var x in Users)
            {
                if (x.TipoUsuario == 1)
                {
                    Eliminados.IsEnabled = true;
                    Eliminados.IsVisible = true;
                    Existentes.IsEnabled = true;
                    Existentes.IsVisible = true;
                    Tareas_Completadas.IsEnabled = true;
                    Tareas_Completadas.IsVisible = true;
                    Todas_Tareas.IsEnabled = true;
                    Todas_Tareas.IsVisible = true;

                    Titulo.Text = "Usuario: " + x.Nombre + " " + x.ApellidoPaterno + " " + x.ApellidoMaterno;
                    Titulo2.Text = "Tareas: ";
                }
                else
                {
                    Titulo.Text = "Usuario: " + x.Nombre + " " + x.ApellidoPaterno + " " + x.ApellidoMaterno;
                    Titulo2.Text = "Tareas: ";
                }
            }
        }

        private async void LeerTareas()
        {
            try
            {
                IEnumerable<TareasJohn> elementos = await Tablet.Where(TareasJohn => TareasJohn.Correos == usuariolocal.ToString() && TareasJohn.Estatus == true).ToEnumerableAsync();
                Itemst = new ObservableCollection<TareasJohn>(elementos);
                BindingContext = this;
                ListaTarea.ItemsSource = Itemst;
                foreach (var x in elementos)
                {
                    if (x.Correos == usuariolocal.ToString())
                    {
                        DateTime Fechasys = DateTime.Now;
                        DateTime FechaTarea = new DateTime(x.Fecha.Year, x.Fecha.Month, x.Fecha.Day);

                        TimeSpan ts = FechaTarea - Fechasys;

                        int DiredenciaDias = ts.Days;
                        await DisplayAlert("Importante", "Le Quedan:" + DiredenciaDias + "Dias Para Completar Su Tarea " + "\nDe: " + x.Tarea.ToString() + "\nDescripcion: " + x.Descripcion.ToString()+ "\nImportancia: " + x.Prioridad.ToString(), "OK");
                    }
                    else
                    {
                        await DisplayAlert("Importante", "No hay tareas Pendientes", "OK");
                    }
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Importante", "La tarea no existe", "ok");
                //await Navigation.PopAsync();
            }
        }

        public async void LeerTareasRealizadas() {
            try
            {
                IEnumerable<TareasJohn> elementos = await Tablet.Where(TareasJohn => TareasJohn.Correos == usuariolocal.ToString() && TareasJohn.Estatus == false).ToEnumerableAsync();
                Itemst = new ObservableCollection<TareasJohn>(elementos);
                BindingContext = this;
                ListaTarea.ItemsSource = Itemst;
                Tareas_Completadas.IsEnabled = false;
                Tareas_Completadas.IsVisible = false;
                Tareas_Pendientes.IsEnabled = true;
                Tareas_Pendientes.IsVisible = true;
                Todas_Tareas.IsEnabled = true;
                Todas_Tareas.IsVisible = true;                
            }

            catch (Exception ex)
            {
                await DisplayAlert("Importante", "La tarea no existe", "ok");
                //await Navigation.PopAsync();
            }

        }

        public async void LeerTodasTareas() {
            try
            {
                IEnumerable<TareasJohn> elementos = await Tablet.ToEnumerableAsync();
                Itemst = new ObservableCollection<TareasJohn>(elementos);
                BindingContext = this;
                ListaTarea.ItemsSource = Itemst;
                Todas_Tareas.IsEnabled = false;
                Todas_Tareas.IsVisible = false;
                Tareas_Pendientes.IsEnabled = true;
                Tareas_Pendientes.IsVisible = true;
                Tareas_Completadas.IsEnabled = true;
                Tareas_Completadas.IsVisible = true;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Importante", "La tarea no existe", "ok");
                //await Navigation.PopAsync();
            }


        }

        private async void ListaTarea_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new CompletarTarea(e.SelectedItem as TareasJohn,usuariolocal.ToString(), PasswordLocal.ToString()));
        }               

        private void Tareas_Completadas_Clicked(object sender, EventArgs e)
        {
            LeerTareasRealizadas();
        }

        private void Todas_Tareas_Clicked(object sender, EventArgs e)
        {
            LeerTodasTareas();
        }

        private void Tareas_Pendientes_Clicked(object sender, EventArgs e)
        {
            LeerTareas();
            Tareas_Completadas.IsEnabled = true;
            Tareas_Completadas.IsVisible = true;
            Tareas_Pendientes.IsEnabled = false;
            Tareas_Pendientes.IsVisible = false;
            Todas_Tareas.IsEnabled = true;
            Todas_Tareas.IsVisible = true;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Usuario != null)
            {
                LeerUsuario();
                LeerTareas();
            }
        }
    }
}
