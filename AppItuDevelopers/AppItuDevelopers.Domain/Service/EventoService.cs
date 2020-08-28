using AppItuDevelopers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppItuDevelopers.Domain.Service
{
    public class EventoService
    {
        private void GetJsonData(string fileName)
        {
        /*    string jsonFileName = fileName;
            var listaDeEventos = new ListaDeEventos();
            var assembly = typeof(VerEvento).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();

                //Converting JSON Array Objects into generic list    
                ObjContactList = JsonConvert.DeserializeObject<ContactList>(jsonString);
            }
            //Binding listview with json string     
            listviewConacts.ItemsSource = ObjContactList.contacts;*/
        }
    }
}
