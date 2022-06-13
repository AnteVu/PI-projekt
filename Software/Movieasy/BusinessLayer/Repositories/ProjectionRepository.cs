using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BusinessLayer.Repositories
{
    public class ProjectionRepository : GenericRepository<Projection>
    {
        private AppDbContext _dbContext { get; set; }
        public ProjectionRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = _appDbContext;
        }

        public List<Projection> GetAllProjections()
        {
            return _dbContext.Projections.Include(x => x.Movie).Include(y => y.Teatre).Include(y => y.Reservations).Include(y => y.Hall).ToList();
        }
    }
}
