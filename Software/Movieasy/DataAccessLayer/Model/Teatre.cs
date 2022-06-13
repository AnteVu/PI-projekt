using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Teatre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string OIB { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }

        public ICollection<Hall> Halls { get; set; }
        public ICollection<Projection> Projections { get; set; }


        public Teatre() 
        {
            Halls = new List<Hall>();
            Projections = new List<Projection>();
        }

        public Teatre(string name, string address, string oib, string phone, string email)
        {
            Name = name;
            Address = address;
            OIB = oib;
            Phone = phone;
            EMail = email;
            Halls = new List<Hall>();
            Projections = new List<Projection>();
        }
    }
}
