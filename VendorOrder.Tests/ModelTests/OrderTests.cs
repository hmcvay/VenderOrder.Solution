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
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
  }
}