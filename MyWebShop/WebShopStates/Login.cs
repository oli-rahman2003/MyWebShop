namespace MyWebShop.WebShopStates;

public class Login : IWebShopState
{
    WebShop webShop;

    public Login(WebShop newWebshop) {
        webShop = newWebshop;
    }
    public void option1() {
        Console.WriteLine("Set username");
    }

    public void option2() {
        Console.WriteLine("Set password");
    }

    public void option3() {
        Console.WriteLine("Login");
    }

    public void option4() {
        Console.WriteLine("Register");
    }
}