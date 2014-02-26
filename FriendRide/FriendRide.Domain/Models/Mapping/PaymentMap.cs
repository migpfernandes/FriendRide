using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FriendRide.Domain.Models.Mapping
{
    public class PaymentMap : EntityTypeConfiguration<Payment>
    {
        public PaymentMap()
        {
            // Primary Key
            this.HasKey(t => t.PaymentId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Payment");
            this.Property(t => t.PaymentId).HasColumnName("PaymentId");
            this.Property(t => t.FromId).HasColumnName("From");
            this.Property(t => t.ToId).HasColumnName("To");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.From)
                .WithMany(t => t.PaymentsMade)
                .HasForeignKey(d => d.FromId);
            this.HasRequired(t => t.To)
                .WithMany(t => t.PaymentsReceived)
                .HasForeignKey(d => d.ToId);

        }
    }
}
