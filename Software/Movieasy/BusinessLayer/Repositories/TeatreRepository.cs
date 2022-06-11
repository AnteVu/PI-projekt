using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    internal class TeatreRepository : GenericRepository<Teatre>
    {
        public TeatreRepository(AppDbContext dbContext) : base(dbContext)   
        {

        }
    }
}
