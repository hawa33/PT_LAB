/*Q.no.6	WAP to print the maximum number from list of number 5,10,11,6,8,9 using for each loop.*/
using System;
using System.Collections.Generic;
public class Qn6
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 5, 10, 11, 6, 8, 9 };
        int maxNumber = numbers[0];  
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The maximum number is: {maxNumber}");
    }
}
