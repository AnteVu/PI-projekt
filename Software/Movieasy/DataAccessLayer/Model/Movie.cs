using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public DateTime LastShowed { get; set; }
        public int NumOfShowing { get; set; }
        public string Description { get; set; }

        public Genre Genre { get; set; }

        public Movie(string name,Genre genre, int duration, string description)
        {
           
            Name = name;
            Genre = genre;
            Duration = duration;
            Description = description;
        }
    }
}
