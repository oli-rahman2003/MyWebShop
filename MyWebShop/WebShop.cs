using MyWebShop.WebShopStates;

namespace MyWebShop;

public class WebShop {
    
    public IWebShopState webShopState { get; set; }

    public WebShop(IWebShopState webShopState) {
            this.webShopState = webShopState;
        }

    public void SeeWares() {
        webShopState.option1();
    }
    public void CustomerInfo() {
        webShopState.option2();
    }
    public void Login() {
        webShopState.option3();
    }
    public void Option4() {
        webShopState.option4();
    }


        
    
}