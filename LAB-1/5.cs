/*Q.no.5	WAP to ask user a day number and print its day using  switch statement.*/
using System;
public class Qn5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a day number 1to7:");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        string dayName;

        switch (dayNumber)
        {
            case 1:
                dayName = "Sunday";
                break;
            case 2:
                dayName = "Monday";
                break;
            case 3:
                dayName = "Tuesday";
                break;
            case 4:
                dayName = "Wednesday";
                break;
            case 5:
                dayName = "Thursday";
                break;
            case 6:
                dayName = "Friday";
                break;
            case 7:
                dayName = "Saturday";
                break;
            default:
                dayName = "Invalid day number";
                break;
        }
        Console.WriteLine($"The day name is: {dayName}");
    }
}
