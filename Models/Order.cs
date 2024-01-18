using System;
using System.Collections.Generic;

namespace DemoGit.Models
{
    public partial class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        //public virtual Customer Customer { get; set; } = null!;

        //public virtual ICollection<OrderRecord> OrderRecords { get; set; } = new List<OrderRecord>();
    }
}
