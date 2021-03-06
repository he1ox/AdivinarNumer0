using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AdivinarNumero
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalculo_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(resultado.Text)) 
                //Si el usuario deja vacio el entry resultado.
            {
                DisplayAlert("ERROR!", "No puedes dejar el campo vacio", "Entiendo");
            }
            else
            {
                /* Suponiendo que el usuario haya hecho las operaciones correctas
                    1. Se elimina el ultimo digito, dividendo entre 10*/
                try
                {
                    var numero = (Convert.ToInt32(resultado.Text) / 10) - 4;
                    DisplayAlert("El numero que pensaste es...", numero.ToString(), "Ok"); 
                }
                catch (FormatException)
                {
                    DisplayAlert("ERROR!", "Dato no valido", "Ok");
                }
            }
        }
    }
}
