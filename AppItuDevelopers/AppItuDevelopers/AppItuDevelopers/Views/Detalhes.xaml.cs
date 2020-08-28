using AppItuDevelopers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace AppItuDevelopers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhes : ContentPage
    {
        public Meetup _meetup;

        public Detalhes(Meetup item)
        {
            _meetup = item;

            InitializeComponent();

            var lblTitulo = this.FindByName<Label>("titulo");
            lblTitulo.Text = item.Name;

            var lblData = this.FindByName<Label>("data");
            lblData.Text = "Data:" + item.Data.ToString("dd/MM/yyyy");
            if (item.Data < DateTime.Now)
                lblData.TextColor = Color.Red;

            var image = this.FindByName<Image>("imagem");
            image.Source = item.ImageUrl;

            var button = this.FindByName<Button>("botao");
            button.Text += item.Location;
            
        }

        private string GetValueData( int value )
        {
            string textReturn = "";
            switch (value)
            {
                case 1:
                    textReturn = "opcao1";
                    break;
                case 2:
                    textReturn = "opcao2";
                    break;
                case 3:
                    textReturn = "opcao3";
                    break;
            }
            return textReturn;
        }

        private async void botao_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Launcher.OpenAsync(new Uri(_meetup.Location));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}