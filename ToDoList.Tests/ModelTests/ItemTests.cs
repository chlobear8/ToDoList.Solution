using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.TestTools
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
  }
}