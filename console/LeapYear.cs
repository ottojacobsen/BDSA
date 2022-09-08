using System;

namespace console;

public class LeapYear {
    public static void Main(String[] args){

        var leap = new LeapYear();

        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(leap.printLeapYear(year));
    }
    public bool isLeapYear(int year) {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
        return false;
    }

    public string printLeapYear(int year)
    {

        var leap = new LeapYear();

        if (leap.isLeapYear(year))
        {
            return "yay";
        } else
        {
            return "nay";
        }
    }
}