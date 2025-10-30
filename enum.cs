using System;

enum Traffic
{
    Red,
    Green,
    Yellow
}

class TrafficLight
{
    public void ShowLight(Traffic light)
    {
        switch (light)
        {
            case Traffic.Green:
                Console.WriteLine("You can go now!");
                break;
            case Traffic.Red:
                Console.WriteLine("You should stop!");
                break;
            case Traffic.Yellow:
                Console.WriteLine("You have to wait!");
                break;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter traffic light (red, green, yellow): ");
        string input = Console.ReadLine().ToLower();

        if (Enum.TryParse(typeof(Traffic), input, true, out object result))
        {
            TrafficLight t1 = new TrafficLight();
            t1.ShowLight((Traffic)result);
        }
        else
        {
            Console.WriteLine("Invalid color!");
        }
    }
}
