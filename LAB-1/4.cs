/*Q.no.4	WAP to ask a number and print its multiplication table using while loop do while loop and for loop.*/
using System;
public class Qn4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Multiplication Table using a while loop:");
        int i = 1;
        while (i <= 10)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
            i++;
        }
        Console.WriteLine("Multiplication Table using a do-while loop:");
        i = 1;
        do
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
            i++;
        } while (i <= 10);

        Console.WriteLine("Multiplication Table using a for loop:");
        for (i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}
