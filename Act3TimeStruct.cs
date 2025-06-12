using System;

struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        minutes = 60 * hh + mm;
    }

    public int Hour
    {
        get { return minutes / 60; }
    }

    public int Minute
    {
        get { return minutes % 60; }
    }

    public override string ToString()
    {
        return String.Format("{0:D2}:{1:D2}", Hour, Minute);
    }
   
}

class Program
{
    static void Main()
    {
        Time t1 = new Time(10, 5);    // 10:05
        Time t2 = new Time(23, 45);   // 23:45
        Time t3 = new Time(0, 9);     // 00:09

        Console.WriteLine(t1);  // Output: 10:05
        Console.WriteLine(t2);  // Output: 23:45
        Console.WriteLine(t3);  // Output: 00:09
        
        Console.WriteLine("Hour: " + t2.Hour);   // 23
        Console.WriteLine("Minute: " + t2.Minute); // 45
    }
}
