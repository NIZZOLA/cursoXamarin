using AppItuDevelopers.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppItuDevelopers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerEventos : ContentPage
    {
        public IList<Meetup> Meetups { get; private set; }

        public VerEventos()
        {
            InitializeComponent();
            Meetups = GetEvents("eventos.json");

            BindingContext = this;
        }

        private IList<Meetup> GetEvents(string fileName )
        {
            try
            {

            string jsonFileName = fileName;
            var listaDeEventos = new List<Meetup>();
            var assembly = typeof(VerEvento).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();

                //Converting JSON Array Objects into generic list    
                listaDeEventos = JsonConvert.DeserializeObject<List<Meetup>>(jsonString);
            }
            //Binding listview with json string     
            //listviewConacts.ItemsSource = ObjContactList.contacts;
            return listaDeEventos;

            }
            catch (Exception err)
            {

                throw;
            }
        }

    }
}