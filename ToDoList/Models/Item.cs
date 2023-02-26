using System.Collections.Generic;
using System;
using ToDoList;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; }
    // private static List<Item> _instances = new List<Item> { };

    public Item(string description)
    {
      Description = description;
      // _instances.Add(this);
      // Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      // Temporarily returning placeholder item to get beyond compiler errors until we refactor to work with database.
      Item placeholderItem = new Item("placeholder item");
      return placeholderItem;
      // return _instances[searchId - 1];
    }
//     public static bool CheckExists(string str)
//     {
//       List<Item>.Contains(Item);
//       //exists.ForEach(Item => Item.Description);
//     }
  }
}