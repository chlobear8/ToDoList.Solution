using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class CategoriesController : Controller
  {

    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Category> allCategories = Category.GetAll();
      return View(allCategories);
      /* index route to display all CategoryS */
    }

    [HttpGet("/categories/new")]
    public ActionResult New()
    {
      return View();
      /* ensures user can create new CategoryS w/ a form */
    }

    [HttpPost("/categories")]
    public ActionResult Create(string categoryName)
    {
      Category newCategory = new Category(categoryName);
      return RedirectToAction("Index");
      /* specify POST
      route accepts a categoryName argument
      in the route create a new Category w/ that name and call RedirectToAction method w/ "Index" passed as argument to send user back to Index route */
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category selectedCategory = Category.Find(id);
      List<Item> categoryItems = selectedCategory.Items;
      model.Add("category", selectedCategory);
      model.Add("items", categoryItems);
      return View(model);
      /* shows both Category and all Item objects saved
      passes two types of objects to the view, but view can only accept one
      create a new Dictionary called model
      add both Category and associated ItemS to Dictionary
      stored as keys "category" and "items"
      Dictionary is named model passed into View() */
    }

// Creates new Items within a given Category, not new Categories:

    [HttpPost("/categories/{categoryId}/items")]
    public ActionResult Create(int categoryId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundCategory = Category.Find(categoryId);
      Item newItem = new Item(itemDescription);
      foundCategory.AddItem(newItem);
      List<Item> categoryItems = foundCategory.Items;
      model.Add("items", categoryItems);
      model.Add("category", foundCategory);
      return View("Show", model);
      /* update method path to follow RESTful convention
      method now takes two arguments, categoryId is passed into hidden form field and itemDescription that contains users input
      create new empty Dictionary named model
      uses categoryId provided as an argument, locates Category object that new Item should belong to and call foundCategory
      create new Item object w/ users input
      add newItem to foundCategory w/ existing AddItem() method
      retrieve all other ItemS in category and add to model
      add foundCategory to model
      pass model data to View() instructing to render Category detail page (Show.cshtml) */
    }

  }
}