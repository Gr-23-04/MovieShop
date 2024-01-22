using System;
using System.Collections.Generic;

namespace MovieShop.Models
{
    public class OrderRow
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int MovieId { get; set; }
        public decimal Price { get; set; }
        public virtual Order Order { get; set; } //foreign key
        public virtual Movie Movie { get; set; } //foreign key
    }

}
