using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models; 
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests 
{
  [TestClass]
  public class VendorTests: IDisposable 
  {

     public void Dispose() 
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstancesOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string vendorName = "Name";
      Vendor newVendor = new Vendor(vendorName);
      string result = newVendor.Name;
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyVendorList_Vendor()
    {
      List<Vendor> newList = new List<Vendor>{};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Vendor1";
      string name02 = "Vendor2";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor>{ newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Vendor1";
      string name02 = "Vendor2";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);

      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);

    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title1 = "title1";
      string description1 = "description1";
      int price1 = 5;
      int date1 = 03042022;
      Order newOrder = new Order(title1, description1, price1, date1);
      List<Order> newList = new List<Order> { newOrder };

      string name = "Vendor1";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}