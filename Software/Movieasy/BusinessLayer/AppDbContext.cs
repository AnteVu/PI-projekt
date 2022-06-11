﻿using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class AppDbContext: DbContext
    {
        public AppDbContext() : base("name=AppContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Hall> Hall { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Projection> Projection { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Teatre> Teatre { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
