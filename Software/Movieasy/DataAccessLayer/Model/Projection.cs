using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Projection
    {
        public int Id { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public Movie Movie { get; set; }
        public Hall Hall { get; set; }
        public Teatre Teatre { get; set; }

        [NotMapped]
        public string MovieName
        {
            get
            {
                return Movie.Name;
            }
        }

        [NotMapped]
        public string TeatreName
        {
            get
            {
                return Teatre.Name;
            }
        }

        [NotMapped]
        public string ReservationsLeft
        {
            get
            {
                return $"{Reservations.Count}/{Hall.Capacity}";
            }
        }

        public ICollection<Reservation> Reservations { get; set; }

        public Projection(Movie movie, Teatre teatre, Hall hall)
        {
            Movie = movie;
            Teatre = teatre;
            Hall = hall;

        }
    }
}
