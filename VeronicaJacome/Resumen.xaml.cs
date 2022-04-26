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
    public partial class Resumen : ContentPage
    {
        public Resumen(String usuario, String nombre, String Total)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
            txtNombre.Text = nombre;
            lblTotal.Text = Total;
        }
    }
}