using System.Collections.Generic;
using System;
using ToDoList;
using MySqlConnector;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int ItemId { get; set; }
    public int CategoryId { get; set;}
    public Category category { get; set; }
  }
}