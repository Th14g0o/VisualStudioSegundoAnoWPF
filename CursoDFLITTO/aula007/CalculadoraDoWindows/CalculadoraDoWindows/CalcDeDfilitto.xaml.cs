using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraDoWindows
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcDeDfilitto : ContentPage
    {
        public CalcDeDfilitto()
        {
            InitializeComponent();
            OnClear(new Object(), new EventArgs());
        }
        int currentState = 1;
        string MathOperator;
        double firstNumber, secondNumber;
        public void OnClear(Object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            Resultado.Text = "0";
            currentState = 1;
        }
        public void OnSelectNumber(Object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string pressed = b.Text;

            if (Resultado.Text == "0" || currentState < 0)
            {
                Resultado.Text = "";
                if (currentState < 0)
                    currentState *= -1;
            
            }

            Resultado.Text += pressed;

            double number;
            if (double.TryParse(Resultado.Text, out number))
            {
                Resultado.Text = number.ToString("N0");//O "N0" serve para colocar virgula nas casas de milhares.Formata numeros.
                if (currentState == 1)
                {
                    firstNumber = number;
                }
                else
                {
                    secondNumber = number;
                }
            }
        }
        public void OnSelectOperator(Object sender, EventArgs e)
        {
            currentState = -2;
            Button b = (Button)sender;
            string pressed = b.Text;
            MathOperator = pressed;
        }
        public void OnCalculate(Object sender, EventArgs e)
        {
            if (currentState == 2)
            {
                double result = 0; 
                if(MathOperator == "+")
                {
                    result = firstNumber + secondNumber;
                }
                if (MathOperator == "-")
                {
                    result = firstNumber - secondNumber;
                }
                if (MathOperator == "/")
                {
                    result = firstNumber / secondNumber;
                }
                if (MathOperator == "X")
                {
                    result = firstNumber * secondNumber;
                }
               
                Resultado.Text = result.ToString();
                firstNumber = result;
                currentState = -1;
            }
        }

    }
}