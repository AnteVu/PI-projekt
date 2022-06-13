using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Description { get; set; }

        public Genre Genre { get; set; }
        public ICollection<Projection> Projections { get; set; }

        [NotMapped]
        public int NumberOfProjections
        {
            get
            {
                return Projections.Count;
            }
        }

        [NotMapped]
        public DateTime? LastShowed
        {
            get
            {
                List<Projection> projections = Projections.Where(x => x.TimeTo < DateTime.Now).ToList();

                if (projections.Count > 0) 
                {
                    return projections.Max(x => x.TimeTo);
                }

                return null;
            }
        }

        [NotMapped]
        public string GenreName { 
            get 
            {
                return Genre.Name;
            } 
        }

        public Movie()
        {

        }

        public Movie(string name, int duration, string description, Genre genre)
        {

            Name = name;
            Duration = duration;
            Genre = genre;
            Description = description;
        }
    }
}
