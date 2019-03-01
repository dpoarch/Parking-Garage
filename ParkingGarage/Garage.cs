namespace ParkingGarage
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ParkingGarage.Models;

    public partial class Garage : DbContext
    {
        public Garage()
            : base("name=Garage")
        {

        }

        public DbSet<ParkingModel.ParkedCars> ParkedCars { get; set; }
        public DbSet<ParkingModel.ParkingGarage> ParkingGarage { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
