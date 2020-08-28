using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppItuDevelopers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contato : ContentPage
    {
        public Contato()
        {
            InitializeComponent();
        }

        private void ButtonMeetup_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonLinkedin_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonEmail_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonTelephone_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:11984701979"));
        }

        private void ButtonWhats_Clicked(object sender, EventArgs e)
        {

        }
    }
}