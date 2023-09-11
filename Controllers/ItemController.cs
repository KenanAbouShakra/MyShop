using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using static System.Net.WebRequestMethods;

namespace MyShop1.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Table()
        {
            var items = new List<Item>();
            var item1 = new Item();
            item1.ItemId = 1;
            item1.Name = "Pizza";
            item1.Price = 60;
            item1.ImageUrl = "https://img.freepik.com/vektoren-premium/fast-food-pizza-symbol-illustration_354956-34.jpg?w=100";
            var item2 = new Item
            {
                ItemId = 2,
                Name = "Fied chicken leg",
                Price = 15,
                ImageUrl = "https://img.freepik.com/premium-vector/fried-chicken-leg-logo-concept_527939-598.jpg?w=100"
            };
            items.Add(item1);
            items.Add(item2);
            ViewBag.CurrentViewName = "List of Shop Items";
            return View(items);

        }
    }
}
