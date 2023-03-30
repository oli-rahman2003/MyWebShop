using MyWebShop.WebShopStates;

namespace MyWebShop;

public class WebShopContext
{
    IWebShopState homePage;
    IWebShopState seeWares;
    IWebShopState customerInfo;
    IWebShopState login;
    
    IWebShopState webShopState;

    public WebShopContext() {
        homePage = new HomePage(this);
        seeWares = new SeeWares(this);
        customerInfo = new CustomerInfo(this);
        login = new Login(this);

        webShopState = homePage;
    }

    public void setWebShopState(IWebShopState newWebShopState) {
        webShopState = newWebShopState;
    }
    public void option1() {
        webShopState.option1();
    }
    public void option2() {
        webShopState.option2();
    }
    public void option3() {
        webShopState.option3();
    }
    public void Option4() {
        webShopState.option4();
    }

    public IWebShopState getHomePageState() { return homePage; }
    public IWebShopState getSeeWaresState() { return seeWares; }
    public IWebShopState getCustomerInfoState() { return customerInfo; }
    public IWebShopState getLoginState() { return login; }




}