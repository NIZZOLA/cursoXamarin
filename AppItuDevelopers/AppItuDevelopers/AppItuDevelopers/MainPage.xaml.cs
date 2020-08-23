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

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Views.Inicial)));
        }

        private void OpenSobre(object sender, EventArgs e)
        {

        }

        private void OpenMeetups(object sender, EventArgs e)
        {

        }

        private void OpenVideos(object sender, EventArgs e)
        {

        }

        private void OpenArtigos(object sender, EventArgs e)
        {

        }

        private void OpenDicas(object sender, EventArgs e)
        {

        }


        private void OpenParceiros(object sender, EventArgs e)
        {

        }

        private void OpenContato(object sender, EventArgs e)
        {

        }





    }
}
