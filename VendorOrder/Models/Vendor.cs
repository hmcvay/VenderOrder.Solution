using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    private static List<Vendor> _instances = new List<Vendor>{};
    // public int Id { get; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);

    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }

     public static void ClearAll()
    {
      _instances.Clear();
    }

     public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}

