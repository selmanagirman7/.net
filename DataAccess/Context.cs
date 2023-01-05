using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<Galery> Galeries { get; set; }
        public DbSet<HomeAbout> HomeAbouts { get; set; }
        public DbSet<OurService> OurServices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vega> VegaProducts { get; set; }
        public DbSet<Referance> Referances { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Image> Images { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=;Database=; user id = sa; password=; Trusted_Connection=false");
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CelebiDb;  Trusted_Connection=true");
        }
    }
}
