/*WAP to find the maximum element form a given queue.*/
using System;
using System.Collections.Generic;

public class Qn3 
{
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(5);
        queue.Enqueue(10);
        queue.Enqueue(11);
        queue.Enqueue(6);
        queue.Enqueue(8);
        queue.Enqueue(9);

        Console.WriteLine("Original Queue:");
        PrintQueue(queue);

        int maxElement = FindMaxElement(queue);

        Console.WriteLine($"\nThe maximum element in the queue is: {maxElement}");
    }

    static int FindMaxElement(Queue<int> queue)
    {
        int maxElement = int.MinValue;

        foreach (int element in queue)
        {
            if (element > maxElement)
            {
                maxElement = element;
            }
        }

        return maxElement;
    }

    static void PrintQueue(Queue<int> queue)
    {
        foreach (int element in queue)
        {
            Console.WriteLine(element);
        }
    }
}
