using Microsoft.EntityFrameworkCore;
using MilesCarRentalApi.Models;



public class ApplicationDbContext: DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Vehicle> Vehicles { get; set; }

    public DbSet<Location> Locations { get; set; }

    public DbSet<Availability> Availabilities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Availability>()
            .HasOne(d => d.Vehicle)
            .WithMany(v => v.Availabilities)
            .HasForeignKey(d => d.VehicleId);

        modelBuilder.Entity<Availability>()
            .HasOne( d => d.Location)
            .WithMany(u=> u.Availabilities)
            .HasForeignKey(d => d.LocationId);
    }

}

