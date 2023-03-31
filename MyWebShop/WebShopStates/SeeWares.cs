namespace MyWebShop.WebShopStates;

public class SeeWares : IWebShopState
{
    WebShopContext webShop;
    
    List<Product> products = new List<Product>();
    Database database = new Database();

    public SeeWares(WebShopContext newWebshop) {
        webShop = newWebshop;
        products = database.GetProducts();
    }
    
    private String CurrentCustomer = "karl";
    
    public void option1() {
        
        Console.WriteLine();
        
        foreach (Product product in products) {
            product.PrintInfo();
        }

        Console.WriteLine();
    }
    
    public void option2() {
        Console.WriteLine("Purchase a ware");
    }
    public void option3() {
        Console.WriteLine("Sort wares");
    }
    public void option4() {
        if (CurrentCustomer == null) {
            Console.WriteLine("Login");
        }
        Console.WriteLine("logout");
    }
}