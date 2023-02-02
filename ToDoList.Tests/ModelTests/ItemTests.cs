using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.TestTools
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
      public void GetDescription_ReturnsDescription_String()
      {
        //Arrange (gather, declare & create)
        string description = "Walk the dog.";
        Item newItem = new Item(description);

        //Act (invoke the functionality call method or retrieving property)
        string result = newItem.Description;

        //Assert (confirm the functionality works as anticipated)
        Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      string updatedDescription = "Do the dishes.";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      //Arrange
      List<Item> newList = new List<Item> { };

      //Act
      List<Item> result = Item.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);

    }
  }
}