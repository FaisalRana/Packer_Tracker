using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class BackpackController : Controller
  {
    [HttpGet("/backpacking")]
    public ActionResult Index()
    {
      // List<Item> newList = new List<Item>();
      // List<Item> backpackingCatalogue = Item.GetAll();
      Item myItem = new Item("Backpack", 12, true);
      List<Item> newList = Item.GetAll();
      return View(newList);
    }

  }
}