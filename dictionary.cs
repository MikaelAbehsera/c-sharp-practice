using System;
using System.Collections.Generic;

public class Hello
{
  public static void Main()
  {
    // TODO: add the inventory dictionary here
    Dictionary<string, long> inventory = new Dictionary<string, long>();
    inventory.Add("apple", 3);
    inventory.Add("orange", 5);
    inventory.Add("banana", 2);
    Console.WriteLine(inventory["apple"]);
    Console.WriteLine(inventory["orange"]);
    Console.WriteLine(inventory["banana"]);

  }
}