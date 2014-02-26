using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FriendRide.Domain.Models.Mapping
{
    public class TripMap : EntityTypeConfiguration<Trip>
    {
        public TripMap()
        {
            // Primary Key
            this.HasKey(t => t.TripId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Trip");
            this.Property(t => t.TripId).HasColumnName("TripId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.DriverID).HasColumnName("DriverID");
            this.Property(t => t.Origin).HasColumnName("Origin");
            this.Property(t => t.Destination).HasColumnName("Destination");

            // Relationships
            this.HasMany(t => t.Passengers)
                .WithMany(t => t.TripsAsPassenger)
                .Map(m =>
                {
                    m.ToTable("TripPassengers");
                    m.MapLeftKey("TripID");
                    m.MapRightKey("PassengerID");
                });

            this.HasRequired(t => t.Driver)
                .WithMany(t => t.TripsAsDriver)
                .HasForeignKey(d => d.DriverID);

        }
    }
}
