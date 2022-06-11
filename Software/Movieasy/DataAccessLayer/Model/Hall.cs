using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Hall
    {
        public int Id { get; set; }
        public int Capacity { get; set; }

        public Teatre Teatre { get; set; }
    }
}
