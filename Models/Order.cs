using System;
using System.Collections.Generic;

namespace MovieShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; } //foreign key

        public ICollection<OrderRow> OrderRows { get; set; }
    }
}
