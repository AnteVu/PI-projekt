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

        public Genre Genre { get; set; }
    }
}
