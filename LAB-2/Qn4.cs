/*WAP to generate the hash table. 
{"One",1}
{"Two",2}
{"Three",3}
and approve the item with the key "Three" form the dictonary and print the remaning dictionary*/
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable hashTable = new Hashtable();

        hashTable.Add("One", 1);
        hashTable.Add("Two", 2);
        hashTable.Add("Three", 3);

        Console.WriteLine("Original Hash Table:");
        PrintHashTable(hashTable);
        hashTable.Remove("Three");

        Console.WriteLine("\nModified Hash Table:");
        PrintHashTable(hashTable);
    }
    static void PrintHashTable(Hashtable hashTable)
    {
        foreach (DictionaryEntry entry in hashTable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
