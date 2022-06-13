using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BusinessLayer.Repositories
{
    public class TeatreRepository : GenericRepository<Teatre>
    {
        private AppDbContext _dbContext { get; set; }

        public TeatreRepository(AppDbContext dbContext) : base(dbContext)   
        {
            _dbContext = _appDbContext;
        }

        public List<Teatre> GetAllTeatres()
        {
            return _dbContext.Teatres.Include(x => x.Halls).ToList();
        }
    }
}
