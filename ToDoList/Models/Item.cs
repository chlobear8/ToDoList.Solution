using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};
    public static List<Item> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }
  }

  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list? ['Add' or 'View']");
      string answer = Console.ReadLine();
      if (answer == "Add" || answer == "add" || answer == "ADD")
      {
        AddToDo();
      }
      else 
      {
        if (answer == "View" || answer == "view" || answer == "VIEW")
      {
        LookUpToDo();
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
    static void AddToDo()
    {
      
    }
    static void LookUpToDo()
    {

    }
  }
  }
}