using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using FriendRide.Domain.Models.Mapping;

namespace FriendRide.Domain.Models
{
    public partial class FriendRideContext : DbContext
    {
        static FriendRideContext()
        {
            Database.SetInitializer<FriendRideContext>(null);
        }

        public FriendRideContext()
            : base("Name=FriendRideContext")
        {
        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PaymentMap());
            modelBuilder.Configurations.Add(new TripMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
