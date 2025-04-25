using Microsoft.AspNetCore.Mvc;
using MyAPP.Models;

namespace MyAPP.Controllers
{
    public class Items : Controller
    {
        // GET: Items
        public ActionResult Overview()
        {
            var item = new Item() {Name="keyboard"};
            return View(item);
        }

    }
}
