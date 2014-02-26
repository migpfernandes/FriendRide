using System;
using System.Collections.Generic;

namespace FriendRide.Domain.Models
{
    public partial class User
    {
        public User()
        {
            this.PaymentsMade = new List<Payment>();
            this.PaymentsReceived = new List<Payment>();
            this.TripsAsDriver = new List<Trip>();
            this.TripsAsPassenger = new List<Trip>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Payment> PaymentsMade { get; set; }
        public virtual ICollection<Payment> PaymentsReceived { get; set; }
        public virtual ICollection<Trip> TripsAsDriver { get; set; }
        public virtual ICollection<Trip> TripsAsPassenger { get; set; }
    }
}
