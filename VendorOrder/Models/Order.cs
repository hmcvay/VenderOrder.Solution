using System.Collections.Generic;

namespace VendorOrder.Models 
{
  public class Order 
  {
    public string Title { get; set; }
    public string Description { get; set; }

    public int Price { get; set; }

    public int Date { get; set; }

    private static List<Order> _instances = new List<Order>{};

    public Order(string title, string description, int price, int date){
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
    }

    public static List<Order> GetAll() {
      return _instances;
    }

  }
}