using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int ItemId { get; set; }
    [Range(1, int.MaxValue)]
    public int CategoryId { get; set;}
    public Category Category { get; set; }
    public List<ItemTag> JoinEntities { get; }
  }
}