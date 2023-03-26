using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;

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

    public void FormatDate()
    {
      string inputString = this.DueDate;
      string[] dateElements = inputString.Split('-');
      DateTime date1 = new DateTime(Int32.Parse(dateElements[0]), Int32.Parse(dateElements[1]), Int32.Parse(dateElements[2]));
      string outputString = date1.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
      this.DueDate = outputString;
    }
  }
}