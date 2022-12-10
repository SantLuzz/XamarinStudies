using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinCalculadora
{
    public partial class MainPage : ContentPage
    {
        //declarando variaveis
        int CurrentState = 1;
        string MathOperator = "";
        double firstNumber, secondNumber;


        public MainPage()
        {
            InitializeComponent();
            LimparControles_Clicked(new object(), new EventArgs());
        }

        /// <summary>
        /// Limpa os controles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LimparControles_Clicked(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            CurrentState = 1;
            this.lblResultado.Text = "0";
        }

        private void SelecionarNumero_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string pressed = bt.Text;

            if(this.lblResultado.Text == "0" || CurrentState < 0)
            {
                this.lblResultado.Text = "";
                if (CurrentState < 0)
                    CurrentState *= -1;
            }

            this.lblResultado.Text += pressed;

            double Number;
            if(double.TryParse(this.lblResultado.Text, out Number))
            {
                this.lblResultado.Text = Number.ToString("N0");
                if (CurrentState == 1)
                    firstNumber = Number;
                else
                    secondNumber = Number;
            }

        }
        
        private void SelecionarOperacao_Clicked(Object sender, EventArgs e)
        {
            CurrentState = -2;
            Button bt = (Button)sender;
            string pressed = bt.Text;
            MathOperator = pressed;
        }

        private void CalcularResultado_Clicked(Object sender, EventArgs e)
        {
            if(CurrentState == 2)
            {
                double result = 0;

                switch (MathOperator)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    default:
                        break;
                }
                this.lblResultado.Text = result.ToString("N0");
                firstNumber = result;
                CurrentState = -1;
            }
        }

    }
}
