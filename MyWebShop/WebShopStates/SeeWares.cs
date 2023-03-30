namespace MyWebShop.WebShopStates;

public class SeeWares : IWebShopState
{
    public void option1() {
        Console.WriteLine("See All Wares");
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