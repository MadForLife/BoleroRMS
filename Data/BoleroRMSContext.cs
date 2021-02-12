using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class BoleroRMSContext : IdentityDbContext<User>
    {
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<HouseKeeper> HouseKeepers { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }

        public BoleroRMSContext() { }
        public BoleroRMSContext(DbContextOptions<BoleroRMSContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Booking>()
                .HasMany(x => x.Guests)
                .WithOne(x => x.Booking)
                .HasForeignKey(x => x.BookingId);

            builder.Entity<Room>()
                .HasMany(x => x.Bookings)
                .WithOne(x => x.Room)
                .HasForeignKey(x => x.RoomId);

            builder.Entity<Guest>()
                .HasOne(x => x.CardDetails)
                .WithOne(x => x.Guest)
                .HasForeignKey<CreditCard>(x => x.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BoleroRMS;Trusted_Connection=True");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
