using System;
using System.Net.Sockets;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        printMenu();
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        var selection = Console.ReadLine();
        while (selection != "5")
        {
            if (selection == "1")
            {
                var breathingActivity = new Breathing();
                breathingActivity.Display();
                Starter();
                breathingActivity.DisplayCountdown();
                breathingActivity.DisplayComplete();
                ReturnToMenu();
            }
            else if (selection == "2")
            {
                var reflectionActivity = new Reflection();
                reflectionActivity.Display();
                Starter();
                reflectionActivity.UserReflect();
                reflectionActivity.DisplayComplete();
                ReturnToMenu();
            }
            else if (selection == "3")
            {
                var listingActivity = new Listing();
                listingActivity.Display();
                listingActivity.DisplayInstructions();
                Starter();
                listingActivity.UserList();
                listingActivity.DisplayComplete();
                ReturnToMenu();
            }
            else if (selection == "4")
            {
                var gratitudeActivity = new Gratitude();
                gratitudeActivity.Display();
                Starter();
                gratitudeActivity.DisplayInstructions();
                gratitudeActivity.GratitudeList();
                gratitudeActivity.DisplayComplete();
                ReturnToMenu();
            }
            Console.Clear();
            printMenu();
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            selection = Console.ReadLine();
        } 
        Console.WriteLine("Goodbye!");
    }

    static void printMenu ()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine();
        Console.WriteLine(" 1. Start breathing activity ");
        Console.WriteLine(" 2. Start reflection activity ");
        Console.WriteLine(" 3. Start listing activity ");
        Console.WriteLine(" 4. Start gratitude activity ");
        Console.WriteLine(" 5. Quit ");
    }

    static void Starter () 
    {
        Thread.Sleep(1000);
        Console.WriteLine("We will start in... ");
        Thread.Sleep(1000);
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

    static void ReturnToMenu () 
    {
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine("We will return to the menu in... ");
        Thread.Sleep(1000);
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

}
