namespace MyWebShop;

public class WebShop
{
    private bool running = true;
    
    private int amountOfOptions = 3;
    private int cursorIsAt = 1;

    private string seeWares = "See wares";
    private string customerInfo = "Customer Info";
    private string login = "Login";
    

    private Customer currentCustomer;
    

    public void Run()
    {
        //while (running)
        {
            WelcomeToTheWebshop();

            WhatWouldYouLikeToDo();

            HomePageMenu();

            NumericalOptions();

            LineBreak();

            InitiateCursor();

            IllustrateCursor();

            LeftRightOkBackQuit();

            CustomerLoginStatus();
            
        }
    }


    private void CustomerLoginStatus() {
        if (currentCustomer != null) {
            Console.WriteLine("Current user: " + currentCustomer.Username);
        }

        else {
            Console.WriteLine("Nobody logged in.");
        }
    }

    private static void WhatWouldYouLikeToDo() {
        Console.WriteLine("What would you like to do?");
    }

    private static void WelcomeToTheWebshop() {
        Console.WriteLine("Welcome to the WebShop");
    }

    private static void LeftRightOkBackQuit() {
        Console.WriteLine("Your buttons are Left, Right, OK, Back and Quit.");
    }

    private static void IllustrateCursor() {
        Console.WriteLine("|");
    }

    private void InitiateCursor() {
        for (int i = 1; i < cursorIsAt; i++) {
            Console.Write("\t");
        }
    }

    private static void LineBreak()
    {
        Console.WriteLine();
    }

    private void NumericalOptions() {
        for (int i = 0; i < amountOfOptions; i++) {
            Console.Write(i + 1 + "\t");
        }
    }

    private void HomePageMenu() {
        Console.WriteLine("1: " + seeWares);
        Console.WriteLine("2: " + customerInfo);
        Console.WriteLine("3: " + login);
    }
    
    
}