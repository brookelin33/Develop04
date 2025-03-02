using System.Diagnostics;
using System.Runtime.CompilerServices;

class Listing 
{
    int _duration;
    public void Display ()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Weclome to the Listing Activity. ");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Int32.Parse (Console.ReadLine());
    }

    public string SelectRandom ()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month? ",
            "Who are some of your personal heros? "
        };

        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }

    public void DisplayInstructions ()
    {
        Console.WriteLine("List as many responses as you can to the following prompt: ");

        string prompt = SelectRandom();
        Console.WriteLine($"---{prompt}---");
    }
    public void UserList () 
    {
        var stopwatch = new Stopwatch();
        var timer = new TimeSpan(0, 0, _duration);
        List<string> list = new List<string> ();
        stopwatch.Start();

        while (stopwatch.Elapsed < timer)
        {
            string userInput = Console.ReadLine();
            list.Add(userInput);
        }


        Console.WriteLine();
        Console.WriteLine($"You listed {list.Count} items.");
    }

    public void DisplayComplete ()
    {
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"Well done! You have completed your listing activity for {_duration} seconds.");
    }

}
