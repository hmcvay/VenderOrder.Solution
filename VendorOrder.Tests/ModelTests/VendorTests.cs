using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models; 
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests 
{
  [TestClass]
  public class VendorTests
  {
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
  }
}