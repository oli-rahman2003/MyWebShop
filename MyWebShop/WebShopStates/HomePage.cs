namespace MyWebShop.WebShopStates;

public class HomePage : IWebShopState
{

    private String CurrentCustomer = "karl";

    WebShopContext webShop;

    public int amountOfOptions = 3;
    public int currentChoice = 1;

    private string seeAllWares = "See all wares";
    private string purchaseAWare = "Purchase a ware";
    private string sortWares = "Sort wares";
    private string login = "Login";
    private string logout = "Logout";

    private string seeYourOrders = "See your orders";
    private string setYourInfo = "Set your info";
    private string addFunds = "Add funds";

    private string setUsername = "Set Username";
    private string setPassword = "Set Password";
    private string register = "Register";
    string username = null;
    string password = null;

    private string currentMenu = "HomePage";

    private Customer currentCustomer;

    public HomePage(WebShopContext newWebShop)
    {
        webShop = newWebShop;
    }

    public void option1() {

        Console.WriteLine("1: " + seeAllWares);
        Console.WriteLine("2: " + purchaseAWare);
        Console.WriteLine("3: " + sortWares);
        
        if (currentCustomer == null) {
            Console.WriteLine("4: " + login);
        }

        else {
            Console.WriteLine("4: " + logout);
        }

        amountOfOptions = 4;
        currentChoice = 1;
        currentMenu = "wares menu";
        Console.WriteLine("What would you like to do?");
    }

    public void option2() {
        
        Console.WriteLine("1: " + seeYourOrders);
        Console.WriteLine("2: " + setYourInfo);
        Console.WriteLine("3: " + addFunds);
        
        if (currentCustomer == null) {
            Console.WriteLine("4: " + login);

            amountOfOptions = 3;
            currentChoice = 1;
            Console.WriteLine("What would you like to do?");
            currentMenu = "customer menu";
        }

        else {
            Console.WriteLine();
            Console.WriteLine("Nobody is logged in.");
            Console.WriteLine();
        }
    }

    public void option3() {
        
        if (currentCustomer == null) {
            
            Console.WriteLine("1: " + setUsername);
            Console.WriteLine("2: " + setPassword);
            Console.WriteLine("3: " + login);
            Console.WriteLine("4: " + register);

            amountOfOptions = 4;
            currentChoice = 1;
            
            Console.WriteLine("Please submit username and password.");
            
            username = null;
            password = null;
            currentMenu = "login menu"; 
        }
        
        else {
            
            Console.WriteLine("Login");
            Console.WriteLine();
            Console.WriteLine(currentCustomer.Username + " logged out.");
            Console.WriteLine();
            
            currentChoice = 1;
            currentCustomer = null;
    }
}

public void option4() {
        throw new NotImplementedException();
    }
}
