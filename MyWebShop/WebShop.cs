namespace MyWebShop;

public class WebShop
{
    bool running = true;
    private string WelcomeToTheWebshop = "Welcome to the WebShop!";
    
    public WebShop() {
    }

    public void Run() {
        Console.WriteLine(WelcomeToTheWebshop);
        
    }
}