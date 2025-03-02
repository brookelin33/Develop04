class Breathing
{
    int _totalDuration;
    public void Display ()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Weclome to the Breathing Activity. ");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _totalDuration = Int32.Parse (Console.ReadLine());
    }

    public void DisplayCountdown ()
    {
        Console.Clear();
        int timer = _totalDuration;
        Console.WriteLine();
        while (timer > 0)
        {
            DisplayBreatheIn();
            timer = timer - 3;
            Console.WriteLine();
            DisplayBreatheOut();
            timer = timer - 5;
            Console.WriteLine();
        }
    }

    public void DisplayBreatheIn ()
    {
        int breathInTimer = 3;
        Console.Write("Breathe in... ");
        while (breathInTimer > 0)
        {
            Console.Write($"{breathInTimer}");
            breathInTimer = breathInTimer - 1;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayBreatheOut ()
    {
        int breathOutTimer = 5;
        Console.Write("Breathe out... ");
        while (breathOutTimer > 0)
        {
            Console.Write($"{breathOutTimer}");
            breathOutTimer = breathOutTimer - 1;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayComplete ()
    {
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"Well done! You have completed your breathing activity for {_totalDuration} seconds.");
    }

}