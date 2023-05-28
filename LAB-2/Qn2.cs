/*WAP to reverse the element of the given stack*/
using System.Collections.Generic;
using System;
public class Qn2{
    static void Main(string[] args){
        Stack<int> stack = new Stack<int>();
    
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        Console.WriteLine("Original Stack:");
        PrintStack(stack);  
    }
    static Stack<int> ReverseStack(Stack<int> stack){
    while (stack.Count > 0)
    {
        int element = stack.Pop();
        reverseStack.Push(element);
    }
    return reversedStack;
    }
    static void PrintStack(Stack<int> stack){
        foreach (int element in stack){
            Console.WriteLine(element);
        }
    }
}
