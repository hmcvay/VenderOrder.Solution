using Microsoft.VisualStudio.TestTools.UnitTesting; 
using System.Collections.Generic;
using System;
using VendorOrder.Models;

namespace VendorOrder.Tests 
{
  [TestClass] 
  public class ItemTests
  {
    // : IDisposable
    // public void Dispose() {
    //   Item.ClearAll();
    // }

    [TestMethod] 
    public void OrderConstructor_CreateInstancesOfOrder_Order() 
    {  
      Order newOrder = new Order("title", "description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod] 
    public void GetTitle_ReturnsTitleOfOrder_String() 
    {  
      string title = "title";
       string description = "description";
      Order newOrder = new Order(title, description);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod] 
    public void GetDescription_ReturnsDescriptionOfOrder_String() 
    {  
      string title = "title";
      string description = "description";
      Order newOrder = new Order(title, description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}