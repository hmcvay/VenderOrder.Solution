using System.Collections.Generic;

namespace VendorOrder.Models 
{
  public class Order 
  {
    public string Title { get; set; }
    // public string Description { get; set; }

    // public int Price { get; set; }

    // public int Date { get; set; }

    public Order(string title) {
      Title = title;
    }

  }
}