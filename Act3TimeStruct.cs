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
    
    public static Time operator +(Time t1, Time t2)
    {
        return new Time(t1.minutes + t2.minutes);
    }

    public static Time operator -(Time t1, Time t2)
    {
        return new Time(t1.minutes - t2.minutes);
    }
   
}

class Program
{
    static void Main()
    {
        Time t1 = new Time(2, 30);      // 02:30
        Time t2 = new Time(1, 45);      // 01:45

        Time sum = t1 + t2;             // 04:15
        Time diff = t1 - t2;            // 00:45

        Console.WriteLine("t1: " + t1);        // 02:30
        Console.WriteLine("t2: " + t2);        // 01:45
        Console.WriteLine("Sum: " + sum);      // 04:15
        Console.WriteLine("Diff: " + diff);    // 00:45
    }
}
