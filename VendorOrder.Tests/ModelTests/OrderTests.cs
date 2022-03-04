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
      Order newOrder = new Order("title");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod] 
    public void GetTitle_ReturnsTitleOfOrder_String() 
    {  
      string title = "title";
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    
  }
}