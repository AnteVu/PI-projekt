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
        private AppDbContext _dbContext { get; set; }
        public MovieRepository(AppDbContext dbContext) : base (dbContext) 
        {
            _dbContext = _appDbContext;
        }

        public List<Movie> GetMovies()
        {
            return _dbContext.Movies.ToList();
        }

    }
}
