using AppItuDevelopers.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppItuDevelopers
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
        }

        private async void OpenSobre(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PageSobre)));
                IsPresented = false;
            }
            catch (Exception err)
            {

                await DisplayAlert("Erro!", err.Message, "OK");
            }
        }

        private async void OpenMeetups(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(VerEventos)));
                IsPresented = false;
            }
            catch (Exception err)
            {

                await DisplayAlert("Erro!", err.Message, "OK");
            }
        }

        private void OpenVideos(object sender, EventArgs e)
        {

        }

        private async void OpenArtigos(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(VerEvento)));
                IsPresented = false;
            }
            catch (Exception err)
            {

                await DisplayAlert("Erro!", err.Message, "OK");
            }
        }

        private void OpenDicas(object sender, EventArgs e)
        {

        }


        private void OpenParceiros(object sender, EventArgs e)
        {

        }

        private async void OpenContato(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Contato)));
                IsPresented = false;
            }
            catch (Exception err)
            {

                await DisplayAlert("Erro!", err.Message, "OK");
            }
        }





    }
}
