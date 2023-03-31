namespace MyWebShop;

public class Database
{
    
    private List<Product> productsInDatabase;
    public Database()
        {
            productsInDatabase = new List<Product>();
            productsInDatabase.Add(new Product("Mirror", 300, 2));
            productsInDatabase.Add(new Product("Car", 2000000, 2));
            productsInDatabase.Add(new Product("Candle", 50, 2));
            productsInDatabase.Add(new Product("Computer", 100000, 2));
            productsInDatabase.Add(new Product("Game", 599, 2));
            productsInDatabase.Add(new Product("Painting", 399, 2));
            productsInDatabase.Add(new Product("Chair", 500, 2));
            productsInDatabase.Add(new Product("Table", 1000, 2));
            productsInDatabase.Add(new Product("Bed", 20000, 2));

        }

    public List<Product> GetProducts()
        {
            return productsInDatabase;
        }
    
}

