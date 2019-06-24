using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyRedo.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        public string year { get; set; }

        public Movie(int id, string name, string year)
        {
            this.id = id;
            this.name = name;
            this.year = year;
        }
    }
}