namespace MyWebShop.WebShopStates;

public class HomePage : IWebShopState {
    
    private String CurrentCustomer = "karl";
    
    WebShopContext webShop;
    
    public HomePage (WebShopContext newWebShop) {
        webShop = newWebShop;
    }
    public void option1() {
        Console.WriteLine("See Wares");
        webShop.setWebShopState(webShop.getSeeWaresState());
    }
    public void option2() {
        Console.WriteLine("Customer Info");
        webShop.setWebShopState(webShop.getCustomerInfoState());
    }
    public void option3() {
        if (CurrentCustomer == null) {
            Console.WriteLine("Log In");
            webShop.setWebShopState(webShop.getLoginState());
        }
        Console.WriteLine("log Out");
    }
    public void option4() {
        throw new NotImplementedException();
    }
}
