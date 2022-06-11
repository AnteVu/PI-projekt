using System;
using System.Collections.Generic;
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
        public ICollection<Reservation> Reservations { get; set; }
    }
}
