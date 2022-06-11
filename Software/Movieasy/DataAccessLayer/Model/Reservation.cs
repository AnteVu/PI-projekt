using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Reservation
    {
        public int Id { get; set; }

        public Projection Projection { get; set; }
    }
}
