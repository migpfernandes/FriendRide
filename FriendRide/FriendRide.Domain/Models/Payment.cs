using System;
using System.Collections.Generic;

namespace FriendRide.Domain.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public decimal Value { get; set; }

        public virtual User From { get; set; }
        public virtual User To { get; set; }
    }
}
