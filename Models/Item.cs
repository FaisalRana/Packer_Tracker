using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Price  { get; set; }
    public bool Available  { get; set; }
    public static List<Item> ItemList = new List<Item>();

  public Item(string description, int price, bool available)
    {
      Description = description;
      Price = price;
      Available = available;
      ItemList.Add(this);
    }

  public static List<Item> GetAll()
    {
      return ItemList;
    }
  }
}
