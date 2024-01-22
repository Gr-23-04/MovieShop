namespace MovieShop.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }

        public ICollection<OrderRow> OrderRows { get; set; }
    }
}