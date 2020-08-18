using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App03_IMC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double peso = Double.Parse(txt_peso.Text);
                double altura = Double.Parse(txt_altura.Text);

                double imc = peso / (altura * altura);
                string classificacao = "";

                if (imc < 17)
                    classificacao = "Muito abaixo do peso";
                else if (imc <= 18.49)
                    classificacao = "Abaixo do peso";
                else if (imc <= 24.99)
                    classificacao = "Peso Normal";
                else if (imc <= 29.99)
                    classificacao = "Acima do Peso";
                else if (imc <= 34.99)
                    classificacao = "Obesidade I";
                else if (imc <= 39.99)
                    classificacao = "Obesidade II (severa)";
                else
                    classificacao = "Obesidade III (mórbida)";

                resultado.Text = "Seu IMC é " + imc.ToString("0.00") + " está " + classificacao;
                resultado.TextColor = Color.Red;
                resultado.HorizontalTextAlignment = TextAlignment.Center;
            }
            catch (Exception ex)
            {
                resultado.Text = "Desculpe, ocorreu um erro \n " + ex.Message;
            }
        }
    }
}
