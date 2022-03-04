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
      Order newOrder = new Order("title", "description", 5, 03042022);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod] 
    public void GetTitle_ReturnsTitleOfOrder_String() 
    {  
      string title = "title";
      string description = "description";
      int price = 5;
      int date = 03042022;
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod] 
    public void GetDescription_ReturnsDescriptionOfOrder_String() 
    {  
      string title = "title";
      string description = "description";
      int price = 5;
      int date = 03042022;
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod] 
    public void GetPrice_ReturnsPriceOfOrder_Int() 
    {  
      string title = "title";
      string description = "description";
      int price = 5;
      int date = 03042022;
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod] 
    public void GetDate_ReturnsDateOfOrder_Int() 
    {  
      string title = "title";
      string description = "description";
      int price = 5;
      int date = 03042022;
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Date;
      Assert.AreEqual(1, result);
    }

  }
}