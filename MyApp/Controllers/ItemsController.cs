using Microsoft.AspNetCore.Mvc;
using MyAPP.Models;

namespace MyAPP.Controllers
{
    public class Items : Controller
    {
        // GET: Items
        public IActionResult Overview()
        {
            var item = new Item() {Name="keyboard"};
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

    }
}
