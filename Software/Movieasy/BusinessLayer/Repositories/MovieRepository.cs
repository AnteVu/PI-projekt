using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public class MovieRepository : GenericRepository<Movie>
    {
        public MovieRepository(AppDbContext dbContext) : base (dbContext) 
        {

        }
    }
}
