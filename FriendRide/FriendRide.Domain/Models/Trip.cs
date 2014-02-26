using System;
using System.Collections.Generic;

namespace FriendRide.Domain.Models
{
    public partial class Trip
    {
        public Trip()
        {
            this.Passengers = new List<User>();
        }

        public int TripId { get; set; }
        public System.DateTime Date { get; set; }
        public int DriverID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public virtual User Driver { get; set; }
        public virtual ICollection<User> Passengers { get; set; }
    }
}
