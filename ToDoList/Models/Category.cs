using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Item> Items { get; set; }

    /* _instances contains static List of all Category objects
    Name contains a name for Category items
    Id contains unique ID # thats assigned in the constructor
    Items contains List of all Item objects that belong to that Category */

    public Category(string categoryName)
    {
      Name = categoryName;
      _instances.Add(this);
      Id = _instances.Count;
      Items = new List<Item>{};
      /* constructor only accepts an argument of categoryName, assigned to Name property
    add each Category to the static _instances list
    assign an ID # equal to # of CategoryS in _instances
    create a new empty List to contain Item objects that belong to this Category */
    }

    public static void ClearAll()
    {
      _instances.Clear();
      /* ClearAll for IDisposable method in testing */

    }
    
    public static List<Category> GetAll()
    {
      return _instances;
      /* retrieves all Category objects to display */
    }

    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
      /* locate and display specific Category Objects */
    }

    public void AddItem(Item item)
    {
      Items.Add(item);
      /* accepts an Item object then uses the List Add() method to save into Items specific Category */
    }

  }
}