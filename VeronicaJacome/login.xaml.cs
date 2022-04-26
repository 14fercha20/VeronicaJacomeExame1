using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VeronicaJacome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            if (txtContrasenia.Text.Equals("uisrael2021") && txtUsuario.Text.Equals("estudiante2021"))
            {
                await Navigation.PushAsync(new Registro(txtUsuario.Text, txtContrasenia.Text));
            }
            else
            {
                DisplayAlert("Alerta", "usuario o contraseña erróneos", "cerrar");

            }
        }
    }
}