using System;

struct Time
{
    private readonly int minutes;

    public Time(int hh, int mm)
    {
        minutes = 60 * hh + mm;
    }

    public Time(int totalMinutes)
    {
        minutes = totalMinutes;
    }

    public int Hour => minutes / 60;
    public int Minute => minutes % 60;

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

    public static implicit operator Time(int totalMinutes)
    {
        return new Time(totalMinutes);
    }

    public static explicit operator int(Time t)
    {
        return t.minutes;
    }

}
   
class Program
{
    static void Main()
    {
        Time t1 = new Time(1, 30);      
        Time t2 = 90;                   
        int mins = (int)t1;            

        Console.WriteLine("t1: " + t1);        
        Console.WriteLine("t2 (from int): " + t2);  
        Console.WriteLine("Minutes in t1: " + mins); 
    }
}
