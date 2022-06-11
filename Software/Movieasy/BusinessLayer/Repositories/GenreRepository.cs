using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public class GenreRepository : GenericRepository<Genre>
    {
        public GenreRepository(AppDbContext dbContext ) : base( dbContext )
        {

        }
    }
}
