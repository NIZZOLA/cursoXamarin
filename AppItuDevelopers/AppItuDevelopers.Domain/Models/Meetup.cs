using System;
using System.Collections.Generic;
using System.Text;

namespace AppItuDevelopers.Domain.Models
{
    public class Meetup
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
