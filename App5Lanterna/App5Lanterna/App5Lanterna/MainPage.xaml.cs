using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Plugin.Battery;
using Xamarin.Forms.Internals;

namespace App5Lanterna
{
    public partial class MainPage : ContentPage
    {
        bool lanternaLigada = false;
        private const string imgOff = "App5Lanterna.Images.botao-desligado.jpg";
        private const string imgOn = "App5Lanterna.Images.botao-ligado.jpg";

        public MainPage()
        {
            InitializeComponent();

            btnOnOff.Source = ImageSource.FromResource(imgOff);

            CarregaInformacoesBateria();
        }

        private async void btnOnOff_Clicked(object sender, EventArgs e)
        {
            try
            {
                if( lanternaLigada )
                {
                    lanternaLigada = false;
                    btnOnOff.Source = ImageSource.FromResource(imgOff);
                    Vibration.Vibrate(TimeSpan.FromMilliseconds(250));
                    await Flashlight.TurnOffAsync();
                }
                else
                {
                    lanternaLigada = true;
                    btnOnOff.Source = ImageSource.FromResource(imgOn);
                    Vibration.Vibrate(TimeSpan.FromMilliseconds(250));
                    await Flashlight.TurnOnAsync();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro \n", ex.Message, "OK");
            }
        }

        private async void CarregaInformacoesBateria()
        {
            try
            {
                if(CrossBattery.IsSupported)
                {
                    CrossBattery.Current.BatteryChanged -= MudancaStatusBateria;
                    CrossBattery.Current.BatteryChanged += MudancaStatusBateria;
                }
                else
                {
                    lbl_bateria_fraca.Text = "As informações sobre a bateria não estão disponíveis :( ";
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ocorreu um erro ao acessar informações da bateria \n", ex.Message, "OK");
            }
        }

        private async void MudancaStatusBateria(object sender, Plugin.Battery.Abstractions.BatteryChangedEventArgs e)
        {
            try
            {
                lbl_porcentagem_restante.Text = e.RemainingChargePercent.ToString() + "%";

                if (e.IsLow)
                    lbl_bateria_fraca.Text = "Atenção ! A bateria está fraca !";
                else
                    lbl_bateria_fraca.Text = "";

                switch (e.Status)
                {
                    case Plugin.Battery.Abstractions.BatteryStatus.Charging:
                        lbl_status.Text = "Carregando";
                        break;
                    case Plugin.Battery.Abstractions.BatteryStatus.Discharging:
                        lbl_status.Text = "Descarregando";
                        break;
                    case Plugin.Battery.Abstractions.BatteryStatus.NotCharging:
                        lbl_status.Text = "não carregando";
                        break;
                    case Plugin.Battery.Abstractions.BatteryStatus.Full:
                        lbl_status.Text = "Cheia";
                        break;
                    case Plugin.Battery.Abstractions.BatteryStatus.Unknown:
                        lbl_status.Text = "Desconhecido";
                        break;
                }

                switch(e.PowerSource)
                {
                    case Plugin.Battery.Abstractions.PowerSource.Ac:
                        lbl_fonte_carregamento.Text = "Carregador";
                        break;
                    case Plugin.Battery.Abstractions.PowerSource.Battery:
                        lbl_fonte_carregamento.Text = "Bateria";
                        break;
                    case Plugin.Battery.Abstractions.PowerSource.Usb:
                        lbl_fonte_carregamento.Text = "Usb";
                        break;
                    case Plugin.Battery.Abstractions.PowerSource.Wireless:
                        lbl_fonte_carregamento.Text = "Sem fio";
                        break;
                    case Plugin.Battery.Abstractions.PowerSource.Other:
                        lbl_fonte_carregamento.Text = "Outros";
                        break;
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Ocorreu um erro ao mudar o status da Bateria \n", ex.Message, "OK");
            }
        }
    }
}
