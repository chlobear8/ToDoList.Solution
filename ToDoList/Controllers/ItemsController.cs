using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/categories/{categoryId}/items/new")]
      public ActionResult New(int categoryId)
      {
        Category category = Category.Find(categoryId);
        return View(category);
        /* path now includes the ID of the Category we're adding new Item to
        in curly braces, can grab this in route's parameter to locate the Category object */
      }

    [HttpGet("/categories/{categoryId}/items/{itemId}")]
      public ActionResult Show(int categoryId, int itemId)
      {
        Item item = Item.Find(itemId);
        Category category = Category.Find(categoryId);
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("item", item);
        model.Add("category", category);
        return View(model);
        /* path now includes Category info which insures RESTfully named
        path includes both Item and Category IDs, we can locate correct parent and child objects and pass to view in Dictionary */
    }
  }
}
