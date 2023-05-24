
/*Q.no.1	WAP to ask user a number and print if it is a positive.*/
using System;  
public class Qn1  
{  
    public static void Main()  
    {
    int num;
    Console.Write("\n\n");
    Console.Write("Check whether a number is positive or negative:\n");
    Console.Write("Input an integer : ");
    num= Convert.ToInt32(Console.ReadLine());//reads input from console in the form of string data type.
    if (num >= 0)

 Console.WriteLine("{0} is a positive number!\n" ,num);
    else
        Console.WriteLine(" Invalid input\n");
}
}
