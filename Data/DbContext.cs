using System.Collections.Generic;

public class DbContext : MovieShopDB
{
    public MovieShopDB<Customers> Customers { get; set; }

}
