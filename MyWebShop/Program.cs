using MyWebShop;
using MyWebShop.WebShopStates;

namespace MyWebShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebShop webShop = new WebShop();
            webShop.Run();

        }
    }
}
/*STATES TEST
WebShopContext webShop = new WebShopContext();
SeeWares seeWares = new SeeWares(new WebShopContext());
Login login = new Login(new WebShopContext());
HomePage homePage = new HomePage(new WebShopContext());
            
webShop.option1();
webShop.option2();
            
seeWares.option1();
            
login.option3();
            
homePage.option1();
homePage.option2();*/