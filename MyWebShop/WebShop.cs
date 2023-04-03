using MyWebShop.Commands;

namespace MyWebShop;

public class WebShop
{
    private bool running = true;
    
    public int amountOfOptions = 3;
    public int currentChoice = 1;
    
    private string seeWares = "See wares";
    private string customerInfo = "Customer Info";
    private string login = "Login";
    private string currentMenu = "HomePage";
    
    string option1 = "See Wares";
    string option2 = "Customer Info";
    string option3 = "Login";
    string option4 = "";
    
    private Customer currentCustomer;

    public void Run()
    {
        WelcomeToTheWebshop();

        while (running)
        {
            WhatWouldYouLikeToDo();

            HomePageMenu();

            NumericalOptions();

            LineBreak();

            InitiateCursor();

            IllustrateCursor();

            LeftRightOkBackQuit();

            CustomerLoginStatus();

            ClickToMoveLeftOrRight();
            
            }
        }

    

    private void ClickToMoveLeftOrRight()
    {
        var choice = GetUserInput();
        
        if (choice == "l" && currentChoice > 1) {
            currentChoice--;
        }

        if (choice == "r" && currentChoice < amountOfOptions) {
            currentChoice++;
        }
    }

    private static string GetUserInput()
    {
        string choice = Console.ReadLine().ToLower();
        return choice;
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
        for (int i = 1; i < currentChoice; i++) {
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

//MOVE RIGHT COMMAND
//IKeyboard keyboard = new WebShopReceiver();
//MoveRightwards onCommand = new MoveRightwards(keyboard);
//KeyboardKeysReceiver onPressed = new KeyboardKeysReceiver(onCommand);
// string choice = Console.ReadLine().ToLower();
//         
//     if (choice == "r") {
//     onPressed.press();