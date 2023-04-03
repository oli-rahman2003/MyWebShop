namespace MyWebShop.Commands;

public class Keyboard
{
    public static IKeyboard GetKeyboard()
    {
        return new WebShopReceiver();
    }
}