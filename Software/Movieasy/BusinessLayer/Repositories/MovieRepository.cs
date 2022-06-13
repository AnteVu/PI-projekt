using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BusinessLayer.Repositories
{
    public class MovieRepository : GenericRepository<Movie>
    {
        private AppDbContext _dbContext { get; set; }
        public MovieRepository(AppDbContext dbContext) : base (dbContext) 
        {
            _dbContext = _appDbContext;
        }

        public List<Movie> GetAllMovies()
        {
            return _dbContext.Movies.Include(x => x.Projections).Include(y => y.Genre).ToList();
        }

    }
}
