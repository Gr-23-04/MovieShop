namespace MovieShop.Models
{
    public partial class OrderRecord
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int MovieId { get; set; }

        public decimal Price { get; set; }


        //public virtual Customer Customer { get; set; } = null!;

        public virtual ICollection<OrderRecord> OrderRecords { get; set; } = new List<OrderRecord>();
    }
}
