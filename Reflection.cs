using System.Diagnostics;

class Reflection 
{
    int _totalDuration;
    public void Display ()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Weclome to the Reflection Activity. ");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _totalDuration = Int32.Parse (Console.ReadLine());
    }

    public string GetPrompt ()
    {
        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        return prompts[new Random ().Next(0, 3)];
    }

    public string GetQuestions ()
    {
        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        return questions[new Random ().Next(0, 8)];
    }

    public void UserReflect ()
    {
        Console.Clear();
        // instructions
        Console.WriteLine ("Consider the following prompt: ");
        // Get prompt
        Console.WriteLine($"---{GetPrompt()}---");
        // Loop for enter to get new questions until time is done
        Console.WriteLine("When you have something in mind, press ENTER. ");
        Console.ReadKey();
        UserQuestions();
    }

    public void UserQuestions ()
    {
        var stopwatch = new Stopwatch();
        var timer = new TimeSpan(0, 0, _totalDuration);
        stopwatch.Start();

        Console.WriteLine("Ponder each question for 5 seconds...");

        while (stopwatch.Elapsed < timer)
        {
            Console.WriteLine($"-- {GetQuestions()}");
            Console.Write("Time left: 5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("Time left: 4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("Time left: 3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("Time left: 2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("Time left: 1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void DisplayComplete ()
    {
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"Well done! You have completed your reflection activity for {_totalDuration} seconds.");
    }
}