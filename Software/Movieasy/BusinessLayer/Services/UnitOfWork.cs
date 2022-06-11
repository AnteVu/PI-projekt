using BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UnitOfWork
    {
        protected AppDbContext _appDbContext { get; set; }
        public GenreRepository Genres { get; set; }
        public HallRepository Halls { get; set; }
        public MovieRepository Movies { get; set; }
        public ProjectionRepository Projections { get; set; }
        public ReservationRepository Reservations { get; set; }
        public TeatreRepository Teatres { get; set; }


        public UnitOfWork(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
            Genres = new GenreRepository(_appDbContext);
            Halls = new HallRepository(_appDbContext);
            Movies = new MovieRepository(_appDbContext);
            Projections = new ProjectionRepository(_appDbContext);
            Reservations = new ReservationRepository(_appDbContext);
            Teatres = new TeatreRepository(_appDbContext);

        }

        public int Complete()
        {
            return _appDbContext.SaveChanges();
        }
    }
}
