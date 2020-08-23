using AppItuDevelopers.Domain.Models;
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
    public partial class VerEvento : ContentPage
    {
        public VerEvento(Evento evento)
        {
            InitializeComponent();
            this.BindingContext = evento;
        }
    }
}