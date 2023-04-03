namespace MyWebShop.Commands;

public class WebShopReceiver : IKeyboard
{
    WebShop webShop = new WebShop();

    public void Right() { 
        
        if (webShop.currentChoice > webShop.amountOfOptions) {
                 webShop.currentChoice++;
             }

        //Console.WriteLine("moved right");
    }
}