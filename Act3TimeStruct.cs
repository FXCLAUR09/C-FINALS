using System;

struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        minutes = 60 * hh + mm;
    }

    public override string ToString()
    {
        return $"{minutes} minutes past midnight";
    }
   
}

class Program
{
    static void Main()
    {
        Time t1 = new Time(10, 5);  // 10:05
        Time t2 = new Time(0, 45);  // 00:45

        Console.WriteLine(t1);  // Output: 605
        Console.WriteLine(t2);  // Output: 45
    }
}
