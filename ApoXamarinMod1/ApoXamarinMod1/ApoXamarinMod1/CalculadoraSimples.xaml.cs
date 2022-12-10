using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApoXamarinMod1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //declarando variaveis
            double a = 0, b = 0, r = 0;

            //verificando se está vazio
            if(string.IsNullOrWhiteSpace(txtValorA.Text) || string.IsNullOrWhiteSpace(txtValorB.Text))
            {
                DisplayAlert("Alerta", "Os Campos não podem ser vazios", "OK");
                return;
            }

            //capturando os valores digitados
            a = Convert.ToDouble(txtValorA.Text);
            b = Convert.ToDouble(txtValorB.Text);

            //pegando o botão pressionado
            Button bt = (Button)sender;
            //verificando qual foi pressionado
            switch (bt.Text)
            {
                case "+":
                    r = a +b;
                    break;
                case "-":
                    r = a - b;
                    break;
                case "/":
                    r = a / b;
                    break;
                case "*":
                    r = a * b;
                    break;
                default:
                    break;
            }

            lblResposta.Text = r.ToString();
        }
    }
}