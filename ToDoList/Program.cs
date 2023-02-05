using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace ToDoList
{

public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list? ['Add' or 'View']");
      string answer = Console.ReadLine();
      if (answer == "Add" || answer == "add" || answer == "ADD")
      {
        Console.WriteLine("What task would you like to add?");
        string task = Console.ReadLine();
        Item newItem = new Item(task);
        {
          Main();
        }
      }
      else if (answer == "View" || answer == "view" || answer == "VIEW")
      {
        List<Item> result = Item.GetAll();
        result.ForEach(item => Console.WriteLine("Here's your to do list: " + item.Description + ","));
      
      }
      else
      {
        Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
        string finishedAnswer = Console.ReadLine();
        if (finishedAnswer == "Y" || finishedAnswer == "y")
        {
          Console.WriteLine("Goodbye.");
        }
        else
        {
          Main();
        }
      }
    }
  }
}
    