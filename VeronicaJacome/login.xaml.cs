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

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals("") && txtContrasenia.Text.Equals(""))
                {
                    DisplayAlert("Aviso", "Campos vacíos", "OK");
                }
                else
                {
                    if (txtUsuario.Text.Equals("estudiante2021") && txtContrasenia.Text.Equals("uisrael2021"))
                    {
                        await Navigation.PushAsync(new Registro(txtUsuario.Text));
                    }
                    else
                    {
                        DisplayAlert("Aviso", "Usuario o contraseña incorrectos", "OK");
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}