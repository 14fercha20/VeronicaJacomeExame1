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
    public partial class Registro : ContentPage
    {
        public Registro(string user, string pass)
        {
            InitializeComponent();
            lbTexto.Text = "Usuario : " + user + " " + "Password : " + pass;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Resumen(user, txtContrasenia.Text));
          
                DisplayAlert("Alerta", "usuario o contraseña erróneos", "cerrar");

            
        }
    }
}