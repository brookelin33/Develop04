using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Gratitude
{
    private int _duration;
    public void Display ()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Weclome to the Gratitude Activity. ");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the positive things in your life by having you list as many things as you can in a certain area. ");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Int32.Parse (Console.ReadLine());
    }

    public void DisplayInstructions ()
    {
        Console.WriteLine("List as many things as you are grateful for: ");
    }

    public void GratitudeList ()
    {
        var stopwatch = new Stopwatch();
        var timer = new TimeSpan(0, 0, _duration);
        List<string> gratitudeList = new List<string> ();
        stopwatch.Start();

        while (stopwatch.Elapsed < timer)
        {
            string gratitude = Console.ReadLine();
            gratitudeList.Add(gratitude);
        }
        


        Console.WriteLine();
        Console.WriteLine("Here is your gratitude list: ");
        foreach (string gratitude in gratitudeList)
        {
            Console.WriteLine(gratitude);
        }
    }

    public void DisplayComplete ()
    {
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"Well done! You have completed your listing activity for {_duration} seconds.");
    }

}  

