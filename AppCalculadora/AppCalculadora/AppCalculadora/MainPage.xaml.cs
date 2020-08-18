using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora
{
    public partial class MainPage : ContentPage
    {
        private double memoriaDeCalculoPreOperacao = 0, memoriaDeCalculoPosOperacao = 0;
        
        private string operacao = null, aparecerVisor = "";

        public MainPage()
        {
            InitializeComponent();
        }

        public void removerSinaisVisor()
        {
            string[] sinais = new string[] { "+", "-", "*", "/" };
            if (sinais.Contains(aparecerVisor))
                aparecerVisor = "";
        }

        private void Btn_igual(object sender, EventArgs e)
        {
            try
            {
                var memoriaDeCalculoPosOperacao = Convert.ToDouble(visor.Text);
                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = memoriaDeCalculoPreOperacao + memoriaDeCalculoPosOperacao;
                        break;
                    case "-":
                        resultado = memoriaDeCalculoPreOperacao - memoriaDeCalculoPosOperacao;
                        break;
                    case "*":
                        resultado = memoriaDeCalculoPreOperacao * memoriaDeCalculoPosOperacao;
                        break;
                    case "/":
                        resultado = memoriaDeCalculoPreOperacao / memoriaDeCalculoPosOperacao;
                        break;
                }
                visor.Text = resultado.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_somar(object sender, EventArgs e)
        {
            try
            {
                memoriaDeCalculoPreOperacao = Convert.ToDouble(visor.Text);
                visor.Text = aparecerVisor = operacao = "+";
            }
            catch (Exception ex)
            {
            visor.Text = ex.Message;
            }
            
        }

        private void Btn_subtrair(object sender, EventArgs e)
        {
            try
            {
                memoriaDeCalculoPreOperacao = Convert.ToDouble(visor.Text);
                visor.Text = aparecerVisor = operacao = "-";
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
            
        }

        private void Btn_multiplicar(object sender, EventArgs e)
        {
            try
            {
                memoriaDeCalculoPreOperacao = Convert.ToDouble(visor.Text);
                visor.Text = aparecerVisor = operacao = "*";
            }
            catch (Exception ex)
            {

                visor.Text = ex.Message;
            }
        }

        private void Btn_dividir(object sender, EventArgs e)
        {
            try
            {
                memoriaDeCalculoPreOperacao = Convert.ToDouble(visor.Text);
                visor.Text = aparecerVisor = operacao = "/";
            }
            catch (Exception ex)
            {

                visor.Text = ex.Message;
            }
            
        }

        private void Btn_zerar(object sender, EventArgs e)
        {
            try
            {
                visor.Text = "0";
                aparecerVisor = "";
                memoriaDeCalculoPreOperacao = memoriaDeCalculoPosOperacao = 0;
                operacao = null;
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
            
        }

        private void Btn_maismenos(object sender, EventArgs e)
        {
            try
            {
                double valor_visor = Convert.ToDouble(visor.Text);
                valor_visor = valor_visor * -1;
                visor.Text = valor_visor.ToString();
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
            
        }

        private void Btn_porcento(object sender, EventArgs e )
        {
            try
            {
                double valor_visor = Convert.ToDouble(visor.Text);
                valor_visor = valor_visor / 100;
                visor.Text = valor_visor.ToString();
            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }
            
        }

        private void Btn_ponto( object sender, EventArgs e)
        {
            aparecerVisor += ponto.Text;
            visor.Text = aparecerVisor;
        }

        private void Btn_0( object sender, EventArgs e)
        {
            pressNumber(num0.Text);
        }

        private void Btn_1(object sender, EventArgs e)
        {
            pressNumber(num1.Text);
        }

        private void Btn_2(object sender, EventArgs e)
        {
            pressNumber(num2.Text);
        }

        private void Btn_3(object sender, EventArgs e)
        {
            pressNumber(num3.Text);
        }

        private void Btn_4(object sender, EventArgs e)
        {
            pressNumber(num4.Text);
        }

        private void Btn_5(object sender, EventArgs e)
        {
            pressNumber(num5.Text);
        }

        private void Btn_6(object sender, EventArgs e)
        {
            pressNumber(num6.Text);
        }

        private void Btn_7(object sender, EventArgs e)
        {
            pressNumber(num7.Text);
        }

        private void Btn_8(object sender, EventArgs e)
        {
            pressNumber(num8.Text);
        }

        private void Btn_9(object sender, EventArgs e)
        {
            pressNumber(num9.Text);
        }

        private void pressNumber(string value)
        {
            removerSinaisVisor();
            visor.Text = aparecerVisor += value;
        }


    }
}
