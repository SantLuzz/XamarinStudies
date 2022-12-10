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
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
            btnExecutar.Clicked += BtnExecutar_Clicked;
        }

        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNumero.Text);
            string resposta = $"O Número {txtNumero.Text} é ";
            //verificando se é par ou não
            if (n % 2 == 0)
                resposta += "Par";
            else
                resposta += "Impar";
            
            //dando o retorno no text
            lblResposta.Text = resposta;
        }
    }
}