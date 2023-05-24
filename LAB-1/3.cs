/*Q.no.3	WAP to ask user a number and check if it is odd, even or zero.*/
using System;
public class Qn3 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine("The number is zero.");
        }
        else if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}
