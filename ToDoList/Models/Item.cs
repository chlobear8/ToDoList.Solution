using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ToDoList.Models
{
  public class Item
  {
    [Required(ErrorMessage = "The item's description can't be empty!")]
    public string Description { get; set; }
    public int ItemId { get; set; }
    public string DueDate { get; set; }
    public bool IsComplete { get; set; } =false;
    [Range(1, int.MaxValue, ErrorMessage= "You must add your item to a category. Have you created a category yet?")]
    public int CategoryId { get; set;}
    public Category Category { get; set; }
    public List<ItemTag> JoinEntities { get; }
  }
}