namespace MyWebShop.WebShopStates;

public class CustomerInfo : IWebShopState
{
    private string CurrentCustomer = "karl";
    
    WebShopContext webShop;

    public CustomerInfo (WebShopContext newWebshop) {
        webShop = newWebshop;
    }

    public void option1() {
        if (CurrentCustomer != null) {
            Console.WriteLine("See your orders");
        }
    }

    public void option2() {
        if (CurrentCustomer != null) {
            Console.WriteLine("Set your info");
        }
    }

    public void option3() {
        if (CurrentCustomer != null) {
            Console.WriteLine("Add funds");
        }
    }

    public void option4() {
        if (CurrentCustomer == null) {
            Console.WriteLine("Login");
        }
        Console.WriteLine("logout");
    }

    
}
