/*Q.no.2	WAP to ask a user a number and check whether it is even or odd.*/
using System;
public class Qno2
{
public static void Main()
{
Int num1,num2;
Console.Write("Input an integer:");
num1= Convert.ToInt32(Console.ReadLine());
num2=num1%2;
if(num2==0)
Console.WriteLine("{0} is an even integer!",num1);
else
Console.WriteLine("{0} is an odd integer!",num1);
}
}
