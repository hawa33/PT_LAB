/*WAP that stores n element in an array and print them*/
using System;
public class Qn1{
    static void Main(string[] args){
        Console.WriteLine("Enter the number of elements:");
        int n= Convert.ToInt32(Console.ReadLine());
        int[] elements= new int[n];
        Console.WriteLine($"Enter {n} elements");
        for(int i=0; i<n; i++){
            Console.WriteLine($"elements {i+1}");
            elements[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("/n The elements in the array are:");
    foreach(int element in elements)
    {
        Console.WriteLine("element");
    }
}
}
