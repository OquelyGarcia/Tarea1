using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageOperaciones : ContentPage
    {
        public PageOperaciones()
        {
            InitializeComponent();
        }
        private void Suma_Clicked(object sender,EventArgs e)
            
        { 
            int n1 = Convert.ToInt32(Num1.Text);
            int n2 = Convert.ToInt32(Num2.Text);
            int Suma = n1 + n2;
            DisplayAlert("Mensaje", Suma.ToString (),"Total");

        }
        private void Resta_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(Num1.Text);
            int n2 = Convert.ToInt32(Num2.Text);
            int Resta = n1 - n2;
            DisplayAlert("Mensaje", Resta.ToString(), "Total");
        }
        private void Division_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(Num1.Text);
            int n2 = Convert.ToInt32(Num2.Text);
            int Division = n1 / n2;
            DisplayAlert("Mensaje", Division.ToString(), "Total");
        }
        private void Multiplicacion_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(Num1.Text);
            int n2 = Convert.ToInt32(Num2.Text);
            int Multiplicacion = n1 * n2;
            DisplayAlert("Mensaje", Multiplicacion.ToString(), "Total");
        }
    }
}